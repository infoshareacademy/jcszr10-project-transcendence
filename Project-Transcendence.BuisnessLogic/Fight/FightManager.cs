using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Dungeons;
using Project_Transcendence.BuisnessLogic.Perks.Ability;
using System.ComponentModel.Design;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class FightManager
    {

        //private BasicPlayer _player;
        //private Enemy _enemy;
        //private Ability _ability;
        //private HealthManager _healthManager;

        //public FightManager(Enemy enemy, BasicPlayer player, Ability ability, HealthManager healthManager)
        //{
        //    _player = player;
        //    _enemy = enemy;
        //    _ability = ability;
        //    _healthManager = healthManager;

        //}

        public void Fight(Enemy enemy, BasicPlayer player, Ability ability, HealthManager healthManager)
        {
            while (player.GetHealth() > 0 && enemy.GetHealth() > 0)
            {
               
                //tutaj trzeba while (jeżeli gracz ma więcej niż 0 żyćka i enemy też to to się wykonuje)
                ICommand playerCommand;
                //A tutaj trzeba ifa z wyborem playera
                playerCommand = new PlayerAttackCommand(player, enemy);
                playerCommand = new CastHealingSpellComand(player, ability);
                playerCommand = new CastDamageSpellCast(player, enemy, ability);
                playerCommand = new DrinkPotionCommand(player);
                
                playerCommand.Execute();

                ICommand enemyCommand;
                //a tu trzeba z wyborem enemy
                enemyCommand = new EnemyAttackCommand(player, enemy);
                enemyCommand = new CastHealingSpellComand(enemy, ability);
                enemyCommand = new CastDamageSpellCast(enemy, player, ability);
                enemyCommand.Execute();


                if (player.GetHealth() == 0)
                {
                    Console.WriteLine($"{enemy.Name} wygrał!");
                }
                else if (enemy.GetHealth() == 0)
                {
                    Console.WriteLine($"Gratulacje {player.Name}, zwycięstwo!");
                }
                else
                {
                    Console.WriteLine("Remis!");
                }

            }

        }
    }

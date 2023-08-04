using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;

namespace Project_Transcendence.BuisnessLogic.Fight
{
    public class FightManager
    {
        private BasicPlayer _player;
        private Enemy _enemy;

        public FightManager(Enemy enemy, BasicPlayer player)
        {
            _player = player;
            _enemy = enemy;
        }

        public bool Fight()
        {
            bool result = false;
            int turn = 0;
            while (true)
            {
                #region // Magia Pauli :D 
                ////tutaj trzeba while (jeżeli gracz ma więcej niż 0 żyćka i enemy też to to się wykonuje)
                //ICommand playerCommand;
                ////A tutaj trzeba ifa z wyborem playera
                //playerCommand = new PlayerAttackCommand(_player, _enemy);
                //playerCommand = new CastHealingSpellComand(_player, ability);
                //playerCommand = new CastDamageSpellCast(_player, _enemy, ability);
                //playerCommand = new DrinkPotionCommand(_player);

                //playerCommand.Execute();

                //ICommand enemyCommand;
                ////a tu trzeba z wyborem enemy
                //enemyCommand = new EnemyAttackCommand(_player, _enemy);
                //enemyCommand = new CastHealingSpellComand(_enemy, ability);
                //enemyCommand = new CastDamageSpellCast(_enemy, _player, ability);
                //enemyCommand.Execute();
                #endregion

                if(turn % 2 == 0) // tura gracza
                {

                }
                else // tura przeciwnika
                {

                }

                turn++;
            }
            return result;
        }

        public bool CheckWhoWon(BasicPlayer player, Enemy enemy)
        {
            bool result = false;

            if(player.GetHealth() < 0) // Player przegrał
            {
                return false;
            }
            else if(enemy.GetHealth() < 0) // Player wygrał
            {
                return true;
            }

            return false;
        }

    }
}

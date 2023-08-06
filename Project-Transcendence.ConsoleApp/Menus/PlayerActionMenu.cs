using Project_Transcendence.BuisnessLogic.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Fight;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class PlayerActionMenu
    {
        private string prompt = "Twoja akcja: ";
        private string[] options = { "Atak bronią", "Rzucenie czaru", "Wypicie mikstury" };
        private CommandInvoker _commandInvoker = new CommandInvoker();
        private BasicPlayer _player;
        private Enemy _enemy;

        public PlayerActionMenu(BasicPlayer player, Enemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public void Run()
        {
            Console.WriteLine("xD");
            Menu menu = new(prompt, options);
            FightManager fightManager = new(_enemy,_player);
            switch (menu.Run())
            {
                case 0:
                    fightManager.Fight(_player.CharacterClass.Abilities[4]);
                    break;

                case 1:
                    ChoseSpellMenu choseSpellMenu = new(_player);
                    var spell = choseSpellMenu.ChoseAbility();
                    fightManager.Fight(spell);
                    break;

                case 2:
                    ICommand command = new DrinkPotionCommand(_player, new Potion(25));
                    _commandInvoker.SetCommand(command);
                    _commandInvoker.ExecuteCommand();
                    break;
            }
        }
    }
}

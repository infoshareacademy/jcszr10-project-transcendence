

using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.PlayerCommands;
using Project_Transcendence.BuisnessLogic.PlayerCommands;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class PlayerActionMenu
    {

        private readonly IPlayerCharacter _player;
        private readonly IEnemy _enemy;

        public PlayerActionMenu(IPlayerCharacter player, IEnemy enemy)
        {
            _player = player;
            _enemy = enemy;
        }

        public ICommand ChoseAction()
        {
            string prompt = "Wybierz akcje!";
            string[] strings = { "Atak bronią", "Rzucenie czaru", "Wypicie mikstury leczacej" };

            Menu menu = new(prompt, strings);

            switch (menu.Run())
            {

                case 0:
                    return new WeaponAttackCommand();

                case 1:
                    ChoseSpellMenu choseSpellMenu = new(_player);
                    return new CastAbilityCommand(_enemy,choseSpellMenu.ChoseAbility());

                case 2:
                    return new DrinkPotionCommand();

                default:
                    break;
            }
            return null;
        }

    }
}

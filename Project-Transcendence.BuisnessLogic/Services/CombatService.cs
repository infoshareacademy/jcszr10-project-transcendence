
using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
using System.Numerics;
using Microsoft.Extensions.DependencyInjection;
using Project_Transcendence.BuisnessLogic.Models.PlayerCommands;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class CombatService
    {
        private IPlayerCharacter _playerCharacter;
        private IEnemy _enemy;

        private readonly HealthService _healthService;
        private readonly StatisticsService _statisticsService;
        private readonly EquipmentService _equipmentService;

        public CombatService(IPlayerCharacter playerCharacter, IEnemy enemy)
        {
            _playerCharacter = playerCharacter;
            _enemy = enemy;
            _healthService = new();
            _statisticsService = new(_playerCharacter);
            if (_playerCharacter is IInventory playerInventory)
            {
            //    _equipmentService = new(playerInventory);
            }
        }

        public void CombatRound(bool isPlayerTurn, ICommand playerAction)
        {
            if (isPlayerTurn) // player turn
            {

                switch (playerAction)
                {
                    case CastAbilityCommand:
                        ICommand spellCommand = playerAction as CastAbilityCommand;
                        CommandInvoker commandInvoker = new();
                        commandInvoker.SetCommand(spellCommand);
                        commandInvoker.ExecuteCommand();
                        break;


                    default:
                        break;
                }

            }
            else // enemy turn
            {



            }
        }

    }
}

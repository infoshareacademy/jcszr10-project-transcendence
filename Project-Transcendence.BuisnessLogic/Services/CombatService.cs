
using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Enemy;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class CombatService
    {
        private bool _isPlayerTurn;
        private bool _combnatInProgress;
        private bool _playerWon;

        private IPlayerCharacter _playerCharacter;
        private IEnemy _enemy;

        private readonly HealthService _healthService;
        private readonly StatisticsService _statisticsService;
        private readonly EquipmentService _equipmentService;

        public CombatService(IPlayerCharacter playerCharacter, IEnemy enemy)
        {
            _isPlayerTurn = true;
            _combnatInProgress = true;
            _playerCharacter = playerCharacter;
            _enemy = enemy;
            _healthService = new();
            _statisticsService = new(_playerCharacter);
            if(_playerCharacter is IInventory playerInventory)
            {
                _equipmentService = new(playerInventory);
            }
        }

        public bool StartCombat()
        {
            Console.WriteLine("Walka!");

            while(_combnatInProgress)
            {
                if(_isPlayerTurn) // player turn
                {
                    PlayerTurn();
                }
                else // enemy turn
                {
                    EnemyTurn();
                }

                CheckCombatStatus();
                if(_playerWon)
                {
                    return true;
                }
                else return false;
            }
            return false;
        }

        private void PlayerTurn()
        {

        }

        private void EnemyTurn()
        {

        }

        private void CheckCombatStatus()
        {
            IHealth playerHealth = _playerCharacter as IHealth;
            IHealth enemyHealth = _enemy as IHealth;

            if(!_healthService.CheckIfAlive(playerHealth))
            {
                _combnatInProgress = false;
                _playerWon = false;
            }
            else if(!_healthService.CheckIfAlive(enemyHealth))
            {
                _combnatInProgress = false;
                _playerWon = true;
                // dawanie przedmiotu graczowi
            }
        }
    }
}

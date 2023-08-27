using Project_Transcendence.BuisnessLogic.Globals;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Dungeons;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class DungeonRunService
    {

        private readonly IPlayerCharacter _playerCharacter;
        private readonly StatisticsService _player;

        public DungeonRunService(IPlayerCharacter playerCharacter)
        {
            _playerCharacter = playerCharacter;
            _player = new(_playerCharacter);
        }

        public bool TraverseDungeons()
        {
            for (int i = _playerCharacter.FinishedDungeonIndex; i < DungeonContainer.Dungeons.Count; i++)
            {
                var x = DungeonContainer.Dungeons[i] as IEnemyDungeon;
                CombatService combatService = new(_playerCharacter, x.EnemyInDungeon);

                if(combatService.StartCombat())
                {
                    _playerCharacter.FinishedDungeonIndex = i;
                    _player.LevelUp();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

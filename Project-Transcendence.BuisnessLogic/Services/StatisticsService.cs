
using Project_Transcendence.BuisnessLogic.Models.Character;
using Project_Transcendence.BuisnessLogic.Models.Character.Player;
using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Services
{
    public class StatisticsService
    {
        private readonly IPlayerCharacter _player;
        public StatisticsService(IPlayerCharacter player)
        {
            _player = player;
        }

        public void LevelUp()
        {
            if(_player is IBasicCharacter playerCharacter)
            {
                playerCharacter.Level++;
            }
            _player.Experience = 0;
            _player.StatisticsManager.IncreaseLuck(5);
            _player.StatisticsManager.IncreaseAgility(5);
            _player.StatisticsManager.IncreaseStrength(5);
            _player.StatisticsManager.IncreaseIntelect(5);
        }

        public int GetIntelect()
        {
            return _player.StatisticsManager.Intelect;
        }
        public int GetAgility()
        {
            return _player.StatisticsManager.Agility;
        }
        public int GetStrength()
        {
            return _player.StatisticsManager.Strength;
        }
        public int GetLuck()
        {
            return _player.StatisticsManager.Luck;
        }

        /// <summary>
        /// This class returns int value that represents chosen statistic: agility,intelect,strength,luck.
        /// </summary>
        /// <param name="statisticType"></param>
        /// <returns></returns>
        public int CalculateStatistic(string statisticType)
        {
            List<Jewelery> jewelery = new List<Jewelery>();
            if (_player is IInventory inventory)
            {
                jewelery = inventory.Jewelery;
            }

            int result = 0;
            switch (statisticType)
            {
                case "intelect":

                    foreach (var item in jewelery)
                    {
                        result += item.GetIntelect();
                    }
                    break;

                case "agility":

                    foreach (var item in jewelery)
                    {
                        result += item.GetAgility();
                    }
                    break;

                case "strength":

                    foreach (var item in jewelery)
                    {
                        result += item.GetStrength();
                    }
                    break;

                case "luck":

                    foreach (var item in jewelery)
                    {
                        result += item.GetLuck();
                    }
                    break;

                default:
                    result = 0;
                    break;
            }
            return result;
        }
    }
}

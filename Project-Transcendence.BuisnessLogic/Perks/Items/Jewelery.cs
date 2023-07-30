
using Project_Transcendence.BuisnessLogic.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Perks.Items
{
    public class Jewelery : Item, IStatistics
    {

        private StatisticsManager _statisticsManager;

        public Jewelery(string name, string description,int intelect = 0, int agility = 0, int strength = 0, int luck = 0)
        {
            Name = name;
            Description = description;
            _statisticsManager = new StatisticsManager(intelect,agility,strength,luck);
        }

        public int GetIntelect()
        {
            return _statisticsManager.Intelect;
        }

        public int GetLuck()
        {
            return _statisticsManager.Luck;
        }

        public int GetAgility()
        {
            return _statisticsManager.Agility;
        }

        public int GetStrength()
        {
            return _statisticsManager.Strength;
        }

        public void IncreaseAgility(int x)
        {
            throw new NotImplementedException();
        }

        public void IncreaseIntelect(int x)
        {
            throw new NotImplementedException();
        }

        public void IncreaseLuck(int x)
        {
            throw new NotImplementedException();
        }

        public void IncreaseStrength(int x)
        {
            throw new NotImplementedException();
        }
    }
}

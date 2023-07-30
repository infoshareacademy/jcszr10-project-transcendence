

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public interface IStatistics
    {
        public int GetIntelect();
        public int GetAgility();
        public int GetStrength();
        public int GetLuck();
        public void IncreaseIntelect(int x);
        public void IncreaseAgility(int x);
        public void IncreaseStrength(int x);
        public void IncreaseLuck(int x);
        public void IncreaseStatistics(int x);
    }
}

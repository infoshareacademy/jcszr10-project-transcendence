using System;
using System.Collections.Generic;
using System.Linq;

namespace Project_Transcendence.BuisnessLogic.Character.Player
{
    public class StatisticsManager
    {

        public int Intelect { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int Armor { get; set; }

        public StatisticsManager(int startingIntelect, int startingAgility, int startingStrength, int startingLuck)
        {
            Intelect = startingIntelect;
            Agility = startingAgility;
            Strength = startingStrength;
            Luck = startingLuck;
        }

        public void IncreaseIntelect(int addToIntelect)
        {
            Intelect += addToIntelect;
        }

        public void IncreaseAgility(int addToAgility)
        {
            Agility += addToAgility;
        }

        public void IncreaseStrength(int addToStrength)
        {
            Strength += addToStrength;
        }

        public void IncreaseLuck(int addToLuck)
        {
            Luck += addToLuck;
        }


    }
}

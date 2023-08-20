﻿using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Models.Character.Player
{
    public class StatisticsManager
    {
        public int Intelect { get; set; }
        public int Agility { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }
        public int Armor { get; set; }

        public StatisticsManager(int startingIntelect = 1, int startingAgility = 1, int startingStrength = 1, int startingLuck = 1)
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
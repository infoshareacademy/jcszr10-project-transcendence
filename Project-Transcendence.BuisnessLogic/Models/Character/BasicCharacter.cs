﻿using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;

namespace Project_Transcendence.BuisnessLogic.Models.Character
{
    public abstract class BasicCharacter : IBasicCharacter, IHealth
    {
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Level { get; set; }
        public HealthManager HealthManager { get; set; }

        public BasicCharacter()
        {
            HealthManager = new();
        }
    }
}
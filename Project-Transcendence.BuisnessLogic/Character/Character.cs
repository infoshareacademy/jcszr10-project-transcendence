﻿using Project_Transcendence.BuisnessLogic.Character;
using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
using Project_Transcendence.ConsoleApp.Perks;

namespace Project_Transcendence.ConsoleApp.Character
{
    public abstract class Character : IHealth, ICharacter  
    {
        public string Name { get; set; }
        public ICharacterRace Race { get; set; }
        public int Health { get; set; }
        public int Level { get; set; }

        public void IncreaseHealth()
        {
            Health += 100;
        }

        public void LevelUp()
        {
            Level++;
        }

        public void TakeDamage(IAbility ability)
        {
            Health -= ability.Damage;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeHealth(IAbility ability)
        {
            Health += ability.Healing;
        }

        public void TakeHealth(int healing)
        {
            Health += healing;
        }   
    }
}

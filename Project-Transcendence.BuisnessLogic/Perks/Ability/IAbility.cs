﻿
namespace Project_Transcendence.BuisnessLogic.Perks.Ability
{
    public interface IAbility
    {
        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}

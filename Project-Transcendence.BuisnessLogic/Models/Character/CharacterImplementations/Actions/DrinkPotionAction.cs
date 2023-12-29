﻿namespace Project_Transcendence.BuisnessLogic.Models.Character.CharacterImplementations.Actions
{
    public class DrinkPotionAction : ICharacterAction
    {
        public string Name => "Drink Potion";

        public void Execute(IBasicCharacter performer, IBasicCharacter target)
        {
            performer.Health.IncreaseHealth(25);
        }
    }
}
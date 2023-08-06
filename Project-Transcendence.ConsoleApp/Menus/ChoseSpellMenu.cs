﻿using Project_Transcendence.BuisnessLogic.Character.Player;
using Project_Transcendence.BuisnessLogic.Perks.Ability;
using Project_Transcendence.BuisnessLogic.Perks.Items;

namespace Project_Transcendence.ConsoleApp.Menus
{
    public class ChoseSpellMenu
    {
        private BasicPlayer _player;
        private string[] _playerAbilities = new string[4];
        private int size = 0;

        public ChoseSpellMenu(BasicPlayer player)
        {
            _player = player;

            for (int i = 0; i < player.CharacterClass.Abilities.Count-1; i++)
            {
                _playerAbilities[size++] = player.CharacterClass.Abilities[i].Name;
            }
        }

        public Ability ChoseAbility()
        {
            Menu menu = new("Wybierz czar: ", _playerAbilities);

            switch (menu.Run())
            {
                case 0:
                    return (Ability)_player.CharacterClass.Abilities[0];

                case 1:
                    return (Ability)_player.CharacterClass.Abilities[1];

                case 2:
                    return (Ability)_player.CharacterClass.Abilities[2];

                case 3:
                    return (Ability)_player.CharacterClass.Abilities[3];
            }
            return (Ability)_player.CharacterClass.Abilities[0];
        }

    }
}


using Project_Transcendence.BuisnessLogic.Models.Character.CharacterClasses;

namespace Project_Transcendence.BuisnessLogic.Models.Character.PlayerCharacter
{
    public interface IPlayer
    {

        public int UserId { get; set; }
        public ICharacterClass CharacterClass { get; set; }
        public int Expirience { get; set; }


    }
}

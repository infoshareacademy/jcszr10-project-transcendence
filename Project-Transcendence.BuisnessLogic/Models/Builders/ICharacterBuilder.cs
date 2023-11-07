using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public interface ICharacterBuilder
    {
        public void SetId();
        public void SetName();
        public void SetRace();
        public void SetClass();
        public void SetLevel();
        public void SetMainHandWeapon();
        public void SetOffHandWeapon();
        public void SetEquipedJewelery();
        public void SetInventory();
        public void SetExpirience();
        public void SetFinishedDungeonIndex();
        public void SetHealthManager();
        public void SetStatisticManager();
        public void SetUserId();

        PlayerCharacter Build();
    }
}

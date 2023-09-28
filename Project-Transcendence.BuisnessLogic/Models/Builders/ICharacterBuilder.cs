using Project_Transcendence.BuisnessLogic.Models.Character.Player;

namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    public interface ICharacterBuilder
    {

        void SetId();
        void SetName();
        void SetRace();
        void SetClass();
        void SetLevel();
        void SetMainHandWeapon();
        void SetOffHandWeapon();
        void SetEquipedJewelery();
        void SetInventory();
        void SetExpirience();
        void SetFinishedDungeonIndex();
        void SetHealthManager();
        void SetStatisticManager();



        PlayerCharacter Build();
    }
}

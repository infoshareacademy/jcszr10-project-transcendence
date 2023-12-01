
namespace Project_Transcendence.BuisnessLogic.Constants
{
    public class DefaultEquipment
    {

        public const int MonkWeaponId = 0;
        public const int WarriorWeaponId = 1;
        public const int WizardWeaponId = 2;
        public const int RogueWeaponId = 3;
        public const int JeweleryId = 4;

        public int DefaultAllClassJeweleryId
        { get
            {
                return JeweleryId;
            }
        }

        public int DefaultWarriorWeaponId
        {
            get
            {
                return MonkWeaponId;
            }
        }

        public int DefaultMonkWeaponId
        {
            get
            {
                return WarriorWeaponId;
            }
        }

        public int DefaultWizardWeaponId
        {
            get
            {
                return WizardWeaponId;
            }
        }

        public int DefaultRogueWeaponId
        {
            get
            {
                return RogueWeaponId;
            }
        }

    }
}

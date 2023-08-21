namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public class Shield : Item, IShield, IWeapon
    {
        public int Armor { get; set; }
        public int Damage { get; set; }

        public Shield(int armor)
        {
            Armor = armor;
        }

    }
}

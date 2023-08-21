namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public class Weapon : Item, IWeapon
    {

        public int Damage { get; set; }

        public Weapon(int damage, string name)
        {
            Name = name;
            Damage = damage;
        }

    }
}

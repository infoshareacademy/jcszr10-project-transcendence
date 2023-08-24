using Newtonsoft.Json;

namespace Project_Transcendence.BuisnessLogic.Models.Perks.Items
{
    public class Weapon : Item, IWeapon
    {

        public int Damage { get; set; }


        [JsonConstructor]
        public Weapon(int damage, string name, string desc, int id)
        {
            Description = desc;
            Name = name;
            Damage = damage;
            Id = id;
        }
        public Weapon(int damage, string name, int id)
        {
            Name = name;
            Damage = damage;
            Id = id;
        }
        public Weapon(int damage, string name)
        {
            Name = name;
            Damage = damage;
        }

    }
}

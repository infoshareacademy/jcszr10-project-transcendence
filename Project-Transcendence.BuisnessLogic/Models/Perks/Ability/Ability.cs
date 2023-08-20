namespace Project_Transcendence.BuisnessLogic.Models.Perks.Ability
{
    public class Ability : IAbility
    {

        public int Damage { get; set; }
        public int Healing { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Ability(string name, string description, int healing, int damage)
        {
            Name = name;
            Description = description;
            Healing = healing;
            Damage = damage;
        }
        public Ability(string name, int damage)
        {
            Name = name;
            Damage = damage;
        }
        public Ability(int dmg)
        {
            Damage = dmg;
        }
    }
}

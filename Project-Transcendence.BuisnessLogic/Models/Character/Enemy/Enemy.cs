namespace Project_Transcendence.BuisnessLogic.Models.Character.Enemy
{
    using Project_Transcendence.BuisnessLogic.Models.Character;
    using Project_Transcendence.BuisnessLogic.Models.Character.CharacterRaces;
    using Project_Transcendence.BuisnessLogic.Models.Perks.Ability;
    using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

    public class Enemy : BasicCharacter, IEnemy
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<IAbility> EnemyAttacks { get; set; }
        public List<IItem> ItemsToDrop { get; set; }

        public Enemy(string name, ICharacterRace race, int health = 100, int level = 1)
        {
            HealthManager = new HealthManager(health);
            Name = name;
            Race = race;
            Level = level;
            EnemyAttacks = new List<IAbility>()
            {
                new Ability(5),
                new Ability(7),
                new Ability(12),
                new Ability(15)
            };
            ItemsToDrop = new List<IItem>()
            {
                new Weapon(5,"asd"),
            };
        }
    }
}

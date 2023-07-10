namespace Project_Transcendence.ConsoleApp.Enemy
{
    using Project_Transcendence.ConsoleApp.Character;
    using Project_Transcendence.ConsoleApp.CharacterRaces;
    using Project_Transcendence.ConsoleApp.Perks;

    public class Enemy : Character, IEnemy
    {
        public List<IAbility> EnemyAttacks { get; set; }
        public List<IItem> ItemsToDrop { get; set; }

        public Enemy(string name, ICharacterRace race, int health = 100, int level = 1)
        {
            Name = name;
            Race = race;
            Health = health;
            Level = level;
            EnemyAttacks = new List<IAbility>()
            {
                new Ability(),
                new Ability(),
                new Ability(),
                new Ability()
            };
            ItemsToDrop = new List<IItem>()
            {
                new Item(),
                new Item()
            };
        }

        public void GiveItem(Player player)
        {
            player.AddToInventory(ItemsToDrop[new Random().Next(ItemsToDrop.Count)]);
        }

        public IAbility Attack()
        {
            return EnemyAttacks[new Random().Next(EnemyAttacks.Count)];
        }
    }
}

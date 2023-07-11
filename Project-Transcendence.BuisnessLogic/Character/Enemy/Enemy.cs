namespace Project_Transcendence.BuisnessLogic.Character.Enemy
{
    using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
    using Project_Transcendence.BuisnessLogic.Character.Player;
    using Project_Transcendence.BuisnessLogic.Perks;
    using Project_Transcendence.BuisnessLogic.Perks.Ability;
    using Project_Transcendence.BuisnessLogic.Perks.Items;
    using Project_Transcendence.ConsoleApp.Character;

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
                new Weapon(),
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

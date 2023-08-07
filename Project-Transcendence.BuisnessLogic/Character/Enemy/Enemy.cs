namespace Project_Transcendence.BuisnessLogic.Character.Enemy
{
    using Project_Transcendence.BuisnessLogic.Character;
    using Project_Transcendence.BuisnessLogic.Character.CharacterRaces;
    using Project_Transcendence.BuisnessLogic.Character.Player;
    using Project_Transcendence.BuisnessLogic.Perks.Ability;
    using Project_Transcendence.BuisnessLogic.Perks.Items;

    public class Enemy : BasicCharacter, IEnemy, IHealth
    {
        public List<IAbility> EnemyAttacks { get; set; }
        public List<IItem> ItemsToDrop { get; set; }
        private HealthManager _healthManager;


        public Enemy(string name, ICharacterRace race, int health = 100, int level = 1)
        {
            _healthManager = new HealthManager(health);
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

        public void GiveItem(BasicPlayer player)
        {
           // player.AddToInventory(ItemsToDrop[new Random().Next(ItemsToDrop.Count)]);
        }

        public IAbility Attack()
        {
            return EnemyAttacks[new Random().Next(EnemyAttacks.Count)];
        }

        public int GetHealth()
        {
            return _healthManager.GetHealth();
        }

        public void TakeDamage(IAbility ability)
        {
            _healthManager.DecreaseHealth(ability.Damage);
        }

        public void TakeDamage(int damage)
        {
            _healthManager.DecreaseHealth((int)damage);
        }

        public void TakeHealth(IAbility ability)
        {
            _healthManager.IncreaseHealth(ability.Healing);
        }

        public void TakeHealth(int healing)
        {
            _healthManager.IncreaseHealth((int)healing);
        }

    }
}

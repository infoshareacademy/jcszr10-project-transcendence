namespace Project_Transcendence_Database.Entities
{
    public class EnumTypes
    {
        public enum ItemType
        {
            Weapon,
            Jewelery,
            Shield,
            Potion
        }

        public enum EnemyType
        {
            Normal,
            Elite,
            Boss
        }

        public enum ItemRarity
        {
            Uncommon,
            Epic,
            Legendary
        }

        public enum AbilityType
        {
            Monk,
            Wizard,
            Warrior,
            Rogue,
            Enemy
        }

        public enum DungeonType
        {
            Enemy,
            Shop,
            Puzzle
        }

        public enum ClassType
        {
            Monk,
            Warrior,
            Wizard,
            Rogue
        }

        public enum ResourceType
        {
            Mana,
            Rage,
            Energy,
            Chi
        }
    }
}

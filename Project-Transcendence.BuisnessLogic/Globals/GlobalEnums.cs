using Project_Transcendence.BuisnessLogic.Models.Perks.Items;

namespace Project_Transcendence.BuisnessLogic.Globals
{
    public static class GlobalEnums
    {
        public enum ItemType
        {
            Weapon,
            Jewelery,
            Shield,
            Potion
        }

        public enum  EnemyType
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

        public enum  ResourceType
        {
            Mana,
            Rage,
            Energy,
            Chi           
        }

        public enum  StateType
        {
            DamageOverTime,
            HealingOverTime,
            Stun,
            Silence,
            Weakened,
            None
        }

    }
}

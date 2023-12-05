
namespace Project_Transcendence.BuisnessLogic.Models.Builders
{
    #nullable disable
    public class Director
    {
        private readonly ICharacterBuilder? _characterBuilder;
        private readonly IItemBuilder? _itemBuilder;
        private readonly IEnemyCharacterBuilder? _enemyCharacterBuilder;
        private readonly IAbilityBuilder? _abilityBuilder;
        private readonly IDungeonBuilder _dungeonBuilder;

        public Director(ICharacterBuilder characterBuilder = null!, IItemBuilder itemBuilder = null!, IEnemyCharacterBuilder enemyCharacterBuilder = null!, IAbilityBuilder? abilityBuilder = null!, IDungeonBuilder dungeonBuilder = null!)
        {
            _characterBuilder = characterBuilder;
            _itemBuilder = itemBuilder;
            _enemyCharacterBuilder= enemyCharacterBuilder;
            _abilityBuilder = abilityBuilder;
            _dungeonBuilder = dungeonBuilder;
        }

        public void ConstructPlayerCharacter()
        {
            _characterBuilder.SetId();
            _characterBuilder.SetName();
            _characterBuilder.SetClass();
            _characterBuilder.SetRace();
            _characterBuilder.SetLevel();
            _characterBuilder.SetExpirience();
            _characterBuilder.SetHealthManager();
            _characterBuilder.SetMainHandWeapon();
            _characterBuilder.SetOffHandWeapon();
            _characterBuilder.SetInventory();
            _characterBuilder.SetEquipedJewelery();
            _characterBuilder.SetStatisticManager();
            _characterBuilder.SetUserId();
        }

        public void ConstructEnemy()
        {
            _enemyCharacterBuilder.SetId();
            _enemyCharacterBuilder.SetName();
            _enemyCharacterBuilder.SetLevel();
            _enemyCharacterBuilder.SetRace();
            _enemyCharacterBuilder.SetAbilities();
            _enemyCharacterBuilder.SetInventory();
        }

        public void ConstructWeapon()
        {
            _itemBuilder.SetId();
            _itemBuilder.SetName();
            _itemBuilder.SetDescription();
            _itemBuilder.SetDamage();
        }

        public void ConstructJewelery()
        {
            _itemBuilder.SetId();
            _itemBuilder.SetName();
            _itemBuilder.SetDescription();
            _itemBuilder.SetStatistics();
        }

        public void ConstructShield()
        {
            _itemBuilder.SetId();
            _itemBuilder.SetName();
            _itemBuilder.SetDescription();
            _itemBuilder.SetArmor();
        }

        public void ConstructPotion()
        {
            _itemBuilder.SetId();
            _itemBuilder.SetName();
            _itemBuilder.SetDescription();
            _itemBuilder.SetHealingAmount();
        }

        public void ConstructAbility()
        {
            _abilityBuilder.SetId();
            _abilityBuilder.SetName();
            _abilityBuilder.SetDescription();
            _abilityBuilder.SetResourceCost();
            _abilityBuilder.SetHealing();
            _abilityBuilder.SetDamage();
        }

        public void ConstructEnemyDungeon()
        {
            _dungeonBuilder.SetId();
            _dungeonBuilder.SetStory();
            _dungeonBuilder.SetLevel();
            _dungeonBuilder.SetEnemies();
            _dungeonBuilder.SetType();
        }

        public void ConstructPuzzleDungeon()
        {
            _dungeonBuilder.SetId();
            _dungeonBuilder.SetStory();
            _dungeonBuilder.SetType();
            _dungeonBuilder.SetPuzzle();
        }

        public void ConstructShopDungeon()
        {
            _dungeonBuilder.SetId();
            _dungeonBuilder.SetStory();
            _dungeonBuilder.SetType();
        }
    }
}

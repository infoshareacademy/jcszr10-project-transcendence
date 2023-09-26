using Microsoft.EntityFrameworkCore;
using Project_Transcendence_Database.Entities;
using System.ComponentModel;
using static Project_Transcendence_Database.Entities.EnumTypes;

namespace Project_Transcendence_Database.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<PlayerCharacter> Characters { get; set; }
        public DbSet<CharacterRace> Races { get; set; }
        public DbSet<CharacterClass> Classes { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<EnemyDungeon> EnemyDungeons { get; set; }
        public DbSet<PuzzleDungeon> PuzzleDungeons { get; set; }
        public DbSet<ShopDungeon> ShopDungeons { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<EquipedJewelery> EquipedJeweleries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EquipedJewelery>()
                .HasKey(ej => new { ej.PlayerCharacterId, ej.ItemId });

            modelBuilder.Entity<PlayerCharacter>()
                 .HasOne(pc => pc.MainHandWeapon)
                 .WithMany()
                 .HasForeignKey(pc => pc.MainHandWeaponId)
                 .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<PlayerCharacter>()
                .HasOne(pc => pc.OffHandWeapon)
                .WithMany()
                .HasForeignKey(pc => pc.OffHandWeaponId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Item>()
                .HasMany<PlayerCharacter>()
                .WithOne(x => x.MainHandWeapon)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Item>()
                 .HasMany<PlayerCharacter>()
                 .WithOne(x => x.OffHandWeapon)
                 .OnDelete(DeleteBehavior.NoAction);


            var itemList = new List<Item>
            {
                new Item { Id = 1, Name = "Zwykły stalowy miecz", Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", Damage = 10, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 2, Name = "Zwykły stalowy sztylet", Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", Damage = 7, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 3, Name = "Zwykłe rękawice mnicha bojowego", Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", Damage = 5, ItemType = EnumTypes.ItemType.Weapon},
                new Item { Id = 4, Name = "Zwykły dębowy kostur", Description = "Zwykły miecz, widać na nim ślady użytkowania ale ogólnie jest w dobrej kondycji", Damage = 5, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 5, Name = "Zwykły pierścień szczęścia", Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększał sczęście o 1", ItemType = EnumTypes.ItemType.Jewelery, Luck = 2 },
                new Item { Id = 6, Name = "Zwykły pierścień zręczności", Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększał zręczność o 1", ItemType = EnumTypes.ItemType.Jewelery, Agility = 2 },
                new Item { Id = 7, Name = "Zwykły pierścień siły", Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększał siłę o 1", ItemType = EnumTypes.ItemType.Jewelery, Strength = 2 },
                new Item { Id = 8, Name = "Zwykły pierścień inteligencji", Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększać inteligencję o 1", ItemType = EnumTypes.ItemType.Jewelery, Intelect = 2 },
                new Item { Id = 9, Name = "Magiczny pierścień", Description = "Srebrny pierścień zaklęty przez kowala tak by zwiększać wszystkie statystyki o 1 ", ItemType = EnumTypes.ItemType.Jewelery, Agility = 1, Intelect = 1, Strength = 1, Luck = 1 },
                new Item { Id = 10, Name = "Pierścień Boga", Description = "TzewohTts elcpamw eiltr hnu'semoy", ItemType = EnumTypes.ItemType.Jewelery, Luck = 100 },
                new Item { Id = 11, Name = "Srebrny sztylet", Description = "Elegancki srebrny sztylet, idealny do skrytych ataków.", Damage = 8, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 12, Name = "Łuk dębowy", Description = "Drewniany łuk dębowy z zestawem strzał.", Damage = 12, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 13, Name = "Topór bojowy", Description = "Ciężki topór bojowy z masywnym ostrzem.", Damage = 15, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 14, Name = "Magiczny różdżka", Description = "Różdżka wykonana z jesionu, zdolna do rzucania potężnych zaklęć.", Damage = 5, ItemType = EnumTypes.ItemType.Weapon },
                new Item { Id = 15, Name = "Naszyjnik mocy", Description = "Naszyjnik imbued z magią, zwiększa siłę o 5", ItemType = EnumTypes.ItemType.Jewelery, Strength = 5 },
                new Item { Id = 16, Name = "Perła mądrości", Description = "Perła o magicznym pochodzeniu, zwiększa inteligencję o 4", ItemType = EnumTypes.ItemType.Jewelery, Intelect = 4 },
                new Item { Id = 17, Name = "Bransoletka zręczności", Description = "Elegancka bransoletka, zwiększa zręczność o 3", ItemType = EnumTypes.ItemType.Jewelery, Agility = 3 },
                new Item { Id = 18, Name = "Pierścień szczęścia", Description = "Tajemniczy pierścień, który przynosi szczęście, zwiększa szczęście o 2", ItemType = EnumTypes.ItemType.Jewelery, Luck = 2 },
                new Item { Id = 19, Name = "Amulet odwagi", Description = "Amulet odwagi, który zwiększa siłę o 3 i zręczność o 2", ItemType = EnumTypes.ItemType.Jewelery, Strength = 3, Agility = 2 }
            };

            var raceList = new List<CharacterRace>
            {
                new CharacterRace { Id = 1, Name = "Człowiek", Description = "Zróżnicowana i wszechstronna rasa ludzi." },
                new CharacterRace { Id = 2, Name = "Elf", Description = "Elegancka i długo żyjąca rasa elfów." },
                new CharacterRace { Id = 3, Name = "Krasnolud", Description = "Silni i wytrwali krasnoludy znane ze swojego rzemiosła." },
                new CharacterRace { Id = 4, Name = "Ork", Description = "Groźni wojownicy orkowie znani ze swojej siły." },
                new CharacterRace { Id = 5, Name = "Niziołek", Description = "Małe i zwinne niziołki, mistrzowie kamuflażu." },
                new CharacterRace { Id = 6, Name = "Driad", Description = "Strażnicy lasów, związani z naturą." },
                new CharacterRace { Id = 7, Name = "Gnom", Description = "Małe wynalazcze gnomowie, znawcy technologii." },
                new CharacterRace { Id = 8, Name = "Aasimar", Description = "Potomkowie ludzi i istot boskich, posiadający boskie dziedzictwo." }
             };

            var resourceList = new List<Resource>
            {
                new Resource { Id = 1, Name = "Energia", Amount = 100, MaxAmount = 100 },
                new Resource { Id = 2, Name = "Gniew", Amount = 100, MaxAmount = 100},
                new Resource { Id = 3, Name = "Mana", Amount = 100, MaxAmount = 100},
                new Resource { Id = 4, Name = "Chi", Amount = 10, MaxAmount = 10},
            };

            var abilityList = new List<Ability>
            {
                    //Monk abilities
                 new Ability { Id = 1, Name = "Umiejętność 1", Description = "Opis umiejętności mnicha 1", Damage = 10, Healing = 0, ResourceCost = 2, ClassType = AbilityType.Monk, CharacterClassId = 1 },
                 new Ability { Id = 2, Name = "Umiejętność 2", Description = "Opis umiejętności mnicha 2", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Monk, CharacterClassId = 1 },
                 new Ability { Id = 3, Name = "Umiejętność 3", Description = "Opis umiejętności mnicha 3", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Monk, CharacterClassId = 1 },
                 new Ability { Id = 4, Name = "Umiejętność 4", Description = "Opis umiejętności mnicha 4", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Monk, CharacterClassId = 1 },
                    //Wizard abilities
                 new Ability { Id = 5, Name = "Umiejętność 1", Description = "Opis umiejętności czarodzieja 1", Damage = 10, Healing = 0, ResourceCost = 2, ClassType = AbilityType.Wizard, CharacterClassId = 2 },
                 new Ability { Id = 6, Name = "Umiejętność 2", Description = "Opis umiejętności czarodzieja 2", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Wizard, CharacterClassId = 2 },
                 new Ability { Id = 7, Name = "Umiejętność 3", Description = "Opis umiejętności czarodzieja 3", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Wizard, CharacterClassId = 2 },
                 new Ability { Id = 8, Name = "Umiejętność 4", Description = "Opis umiejętności czarodzieja 4", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Wizard, CharacterClassId = 2 },
                    //Rogue abilities
                 new Ability { Id = 9, Name = "Umiejętność 1", Description = "Opis umiejętności łotrzyka 1", Damage = 10, Healing = 0, ResourceCost = 2, ClassType = AbilityType.Rogue, CharacterClassId = 3 },
                 new Ability { Id = 10, Name = "Umiejętność 2", Description = "Opis umiejętności łotrzyka 2", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Rogue, CharacterClassId = 3 },
                 new Ability { Id = 11, Name = "Umiejętność 3", Description = "Opis umiejętności łotrzyka 3", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Rogue, CharacterClassId = 3 },
                 new Ability { Id = 12, Name = "Umiejętność 4", Description = "Opis umiejętności łotrzyka 4", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Rogue, CharacterClassId = 3 },
                    // Warrior abilities
                 new Ability { Id = 13, Name = "Umiejętność 1", Description = "Opis umiejętności wojownika 1", Damage = 10, Healing = 0, ResourceCost = 2, ClassType = AbilityType.Warrior, CharacterClassId = 4 },
                 new Ability { Id = 14, Name = "Umiejętność 2", Description = "Opis umiejętności wojownika 2", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Warrior, CharacterClassId = 4 },
                 new Ability { Id = 15, Name = "Umiejętność 3", Description = "Opis umiejętności wojownika 3", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Warrior, CharacterClassId = 4 },
                 new Ability { Id = 16, Name = "Umiejętność 4", Description = "Opis umiejętności wojownika 4", Damage = 15, Healing = 0, ResourceCost = 1, ClassType = AbilityType.Warrior, CharacterClassId = 4 }
            };

            var classList = new List<CharacterClass>
            {
                new CharacterClass { Id = 1, Name = "Mnich", Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", ResourceId = 4},
                new CharacterClass { Id = 2, Name = "Czarodziej", Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", ResourceId = 3},
                new CharacterClass { Id = 3, Name = "Łotrzyk", Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", ResourceId = 1},
                new CharacterClass { Id = 4, Name = "Wojownik", Description = "Mnich to duchowy wojownik, mistrz w sztukach walki opartych na medytacji i kontroli nad energią życiową", ResourceId = 2}
            };

            var inventoryList = new List<Inventory>
            {
                new Inventory { Id = 2, PlayerCharacterId = 1 },
                new Inventory { Id = 3, EnemyId = 1 }
            };

            var userList = new List<User>
            {
                new User {Id = 50, Login = "admin", Password = "admin"}
            };

            var characterList = new List<PlayerCharacter>
            {
                new PlayerCharacter { Id = 1, Name = "Json", CharacterClassId = 1, CharacterRaceId = 1, Expirience = 0, MainHandWeaponId = itemList[3].Id, OffHandWeaponId = itemList[3].Id, UserId = 50 },
            };

            var enemyList = new List<Enemy>
            {
                new Enemy { Id = 1, Name = "Andrzej", RaceId = 4, Level = 1 }
            };

            var inventoryItems = new List<object>
            {
                new { InventoriesId = 2, ItemsId = 1 },
                new { InventoriesId = 2, ItemsId = 2 },
                new { InventoriesId = 2, ItemsId = 3 },
                new { InventoriesId = 2, ItemsId = 11 },
                new { InventoriesId = 3, ItemsId = 9 },
                new { InventoriesId = 3, ItemsId = 10 },
                new { InventoriesId = 3, ItemsId = 14 },
                new { InventoriesId = 3, ItemsId = 15 }
            };                               


            foreach (var item in itemList)
            {
                modelBuilder.Entity<Item>().HasData(item);
            }

            foreach (var race in raceList)
            {
                modelBuilder.Entity<CharacterRace>().HasData(race);
            }

            foreach (var resource in resourceList)
            {
                modelBuilder.Entity<Resource>().HasData(resource);
            }

            foreach (var ability in abilityList)
            {
                modelBuilder.Entity<Ability>().HasData(ability);
            }

            foreach (var charClass in classList)
            {
                modelBuilder.Entity<CharacterClass>().HasData(charClass);
            }

            foreach (var user in userList)
            {
                modelBuilder.Entity<User>().HasData(user);
            }

            foreach (var item in characterList)
            {
                modelBuilder.Entity<PlayerCharacter>().HasData(item);
            }

            foreach (var item in inventoryList)
            {
                modelBuilder.Entity<Inventory>().HasData(item);
            }

            foreach (var item in inventoryItems)
            {
                modelBuilder.Entity("InventoryItem").HasData(item);
            }

            foreach (var item in enemyList)
            {
                modelBuilder.Entity<Enemy>().HasData(item);
            }

            base.OnModelCreating(modelBuilder);

        }
    }
}

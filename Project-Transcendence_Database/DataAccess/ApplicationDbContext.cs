using Microsoft.EntityFrameworkCore;
using Project_Transcendence_Database.Entities;

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
        public DbSet<User> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<EquipedJewelery> EquipedJeweleries { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
            modelBuilder.Entity<EquipedJewelery>()
                .HasKey(ej => new {ej.PlayerCharacterId, ej.ItemId});

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


            base.OnModelCreating(modelBuilder);

        }

    }

    

}

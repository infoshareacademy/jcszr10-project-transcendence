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
        public DbSet<PuzzleDungeon> PuzzleDungeons { get; set; }
        public DbSet<ShopDungeon> ShopDungeons { get; set; }
        public DbSet<Jewelery> Jeweleries { get; set; }
        public DbSet<Shield> Shields { get; set; }
        public DbSet<Potion> Potions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Inventory> Inventories { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}

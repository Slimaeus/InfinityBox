using InfinityBox.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterStat> CharacterStats { get; set; }
        public DbSet<CharacterType> CharacterTypes { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<StatModifier> StatModifiers { get; set; }
        public DbSet<EffectStatModifier> EffectStatModifiers { get; set; }
        public DbSet<Evolution> Evolutions { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Passive> Passives { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<StatRate> StatRates { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<UserBank> UserBanks { get; set; }
        public DbSet<UserCharacter> UserCharacters { get; set; }
        public DbSet<UserPocket> UserPockets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CharacterStat>()
                .HasKey(x => new { x.CharacterId, x.StatId });

            modelBuilder.Entity<EffectStatModifier>()
                .HasKey(x => new { x.EffectId, x.StatModifierId});
        }
    }
}

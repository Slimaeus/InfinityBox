using InfinityBox.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfinityBox.Infrastructure.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Stat> Stats { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<UserCharacter> UserCharacters { get; set; }
        public DbSet<Effect> Effects { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CharacterType> CharacterTypes { get; set; }
        
    }
}

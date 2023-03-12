using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;
using InfinityBox.Infrastructure.SeedData;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace InfinityBox.Infrastructure.Persistence
{
    public class ApplicationDbContextInitializer
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDbContextInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task InitialiseAsync()
        {
            try
            {
                await _context.Database.MigrateAsync();

            }
            catch (Exception ex)
            {
                Log.Error(ex, "Migration error");
            }
        }

        public async Task SeedAsync()
        {
            try
            {
                await TrySeedAsync();
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Seeding error");
            }
        }

        public async Task TrySeedAsync()
        {
            if (!_context.Stats.Any())
            {
                _context.Stats.AddRange(Stats.List);
            }

            if (!_context.CharacterTypes.Any())
            {
                _context.CharacterTypes.AddRange(CharacterTypes.List);
            }

            if (!_context.StatModifiers.Any())
            {
                _context.StatModifiers.AddRange(StatModifiers.List);
            }
            
            if (!_context.Effects.Any())
            {
                _context.Effects.AddRange(Effects.List);
            }

            //if (!_context.EffectStatModifiers.Any())
            //{
            //    _context.EffectStatModifiers.AddRange(EffectStatModiers.List);
            //}

            if (!_context.Skills.Any())
            {
                _context.Skills.AddRange(Skills.List);
            }

            if (!_context.Passives.Any())
            {
                _context.Passives.AddRange(Passives.List);
            }

            if (!_context.Characters.Any())
            {
                _context.Characters.AddRange(Characters.List);
            }

            await _context.SaveChangesAsync();
        }

    }
}

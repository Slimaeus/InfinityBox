using InfinityBox.Domain.Entities;
using InfinityBox.Domain.Enums;
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
            // Default data
            // Seed, if necessary
            if (!_context.Effects.Any())
            {
                var effects = new List<Effect>()
                {
                    new Effect {
                        Name = "Physical Attack",
                        Description = "Deals physical damage to the target.",
                        Type = EffectTypes.PhysicalDamage,
                        SourceType = StatType.PHY_ATK,
                        DestinationType = StatType.HP,
                        Value = 0.5,
                        Duration = 0
                    },
                    new Effect {
                        Name = "Magical Attack",
                        Description = "Deals magical damage to the target.",
                        Type = EffectTypes.MagicalDamage,
                        SourceType = StatType.MAG_ATK,
                        DestinationType = StatType.HP,
                        Value = 0.5,
                        Duration = 0
                    },
                    new Effect {
                        Name = "Heal",
                        Description = "Restores health to the target.",
                        Type = EffectTypes.Heal,
                        SourceType = StatType.MAG_ATK,
                        DestinationType = StatType.HP,
                        Value = 0.5,
                        Duration = 0
                    },
                    new Effect {
                        Name = "Stun",
                        Description = "Stuns the target.",
                        Type = EffectTypes.Stun,
                        SourceType = StatType.None,
                        DestinationType = StatType.None,
                        Value = 0.1,
                        Duration = 2
                    },
                    new Effect {
                        Name = "Burn",
                        Description = "Deals fire damage over time to the target.",
                        Type = EffectTypes.Burn,
                        SourceType = StatType.MAG_ATK,
                        DestinationType = StatType.HP,
                        Value = 5,
                        Duration = 3
                    },
                    new Effect {
                        Name = "Poison",
                        Description = "Deals poison damage over time to the target.",
                        Type = EffectTypes.Poison,
                        SourceType = StatType.MAG_ATK,
                        DestinationType = StatType.HP,
                        Value = 0.05,
                        Duration = 3
                    },
                    new Effect {
                        Name = "Bleeding",
                        Description = "Deals bleeding damage over time to the target.",
                        Type = EffectTypes.Bleeding,
                        SourceType = StatType.None,
                        DestinationType = StatType.HP,
                        Value = 0.03,
                        Duration = 3
                    },
                    new Effect {
                        Name = "Silent",
                        Description = "Silences the target.",
                        Type = EffectTypes.Silent,
                        SourceType = StatType.None,
                        DestinationType = StatType.None,
                        Value = 0,
                        Duration = 2
                    }
                };

                _context.Effects.AddRange(effects);
                await _context.SaveChangesAsync();
            }
        }

    }
}

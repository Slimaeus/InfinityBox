using InfinityBox.Domain.Entities;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Stats
    {
        public static readonly Stat HP = new Stat { Id = 1, Name = "HP", Description = "Health point", Type = Domain.Enums.CharacterStatType.MHP };
        public static readonly Stat K_ATK = new Stat { Id = 2, Name = "KINETIC_ATK", Description = "Kinetic attack point", Type = Domain.Enums.CharacterStatType.KATK };
        public static readonly Stat K_DEF = new Stat { Id = 3, Name = "KINETIC_DEF", Description = "Kinetic defence point", Type = Domain.Enums.CharacterStatType.KDEF };
        public static readonly Stat E_ATK = new Stat { Id = 4, Name = "ENERGY_ATK", Description = "Energy attack point", Type = Domain.Enums.CharacterStatType.KATK };
        public static readonly Stat E_DEF = new Stat { Id = 5, Name = "ENERGY_DEF", Description = "Energy defence point", Type = Domain.Enums.CharacterStatType.KDEF };
        public static readonly Stat SPD = new Stat { Id = 6, Name = "SPD", Description = "Speed point", Type = Domain.Enums.CharacterStatType.SPD };

        public static readonly List<Stat> List = new List<Stat>
        {
            HP, K_ATK, K_DEF, E_ATK, E_DEF, SPD
        };
    }
}

using InfinityBox.Domain.Entities;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Stats
    {
        public static Stat HP = new Stat { Id = 1, Name = "HP", Description = "Health point", Type = Domain.Enums.CharacterStatType.MAX_HP };
        public static Stat PHY_ATK = new Stat { Id = 2, Name = "PHY_ATK", Description = "Physical attack point", Type = Domain.Enums.CharacterStatType.PHY_ATK };
        public static Stat PHY_DEF = new Stat { Id = 3, Name = "PHY_DEF", Description = "Physical defence point", Type = Domain.Enums.CharacterStatType.PHY_DEF };
        public static Stat MAG_ATK = new Stat { Id = 4, Name = "MAG_ATK", Description = "Magical attack point", Type = Domain.Enums.CharacterStatType.MAG_ATK };
        public static Stat MAG_DEF = new Stat { Id = 5, Name = "MAG_DEF", Description = "Magical defence point", Type = Domain.Enums.CharacterStatType.MAG_DEF };
        public static Stat SPD = new Stat { Id = 6, Name = "SPD", Description = "Speed point", Type = Domain.Enums.CharacterStatType.SPD };

        public static List<Stat> List = new List<Stat>
        {
            HP, PHY_ATK, PHY_DEF, MAG_ATK, MAG_DEF, SPD
        };
    }
}

using InfinityBox.Domain.Entities;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Passives
    {
        public static Passive DoubleMaxHP = new Passive
        {
            Id = 3,
            Name = "Increase Max HP",
            Description = "Increases the character's maximum HP.",
            Effects = new List<Effect>() { Effects.BoostHP }
        };

        public static List<Passive> List = new List<Passive>()
        {
            DoubleMaxHP
        };
    }
}

using InfinityBox.Domain.Entities;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Skills
    {
        public static Skill BasicAttack = new Skill
        {
            Id = 1,
            Name = "Basic Attack",
            Description = "A simple physical attack.",
            Cost = 0,
            Cooldown = 0,
            Effects = new List<Effect> { Effects.PhysicalAttack }
        };

        public static Skill Fireball = new Skill
        {
            Id = 2,
            Name = "Fireball",
            Description = "A magical attack that deals fire damage.",
            Cost = 10,
            Cooldown = 3,
            Effects = new List<Effect> { Effects.MagicalAttack, Effects.Burn }
        };

        public static Skill Heal = new Skill
        {
            Id = 3,
            Name = "Heal",
            Description = "Restores health to the target.",
            Cost = 10,
            Cooldown = 3,
            Effects = new List<Effect> { Effects.Heal }
        };

        public static Skill Stun = new Skill
        {
            Id = 4,
            Name = "Stun",
            Description = "Stuns the target.",
            Cost = 20,
            Cooldown = 5,
            Effects = new List<Effect> { Effects.Stun }
        };

        public static Skill Poison = new Skill
        {
            Id = 5,
            Name = "Poison",
            Description = "Poisons the target, dealing damage over time.",
            Cost = 10,
            Cooldown = 3,
            Effects = new List<Effect> { Effects.Poison }
        };

        public static Skill Grow = new Skill
        {
            Id = 6,
            Name = "Grow",
            Description = "The user grows in size, increasing max HP.",
            Cost = 0,
            Cooldown = 3,
            Effects = new List<Effect> { Effects.BoostHP }
        };

        public static List<Skill> List => new List<Skill>()
        {
            BasicAttack,
            Fireball,
            Heal,
            Stun,
            Poison,
            Grow
        };
    }
}

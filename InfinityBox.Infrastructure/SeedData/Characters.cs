using InfinityBox.Domain.Entities;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class Characters
    {
        public static readonly Character SwordMan = new Character
        {
            Id = 1,
            BaseExperience = 10,
            Name = "Sword man",
            Description = "I am a swordman",
            ImageUrl = "https://www.shutterstock.com/image-vector/medieval-knight-wearing-armor-holds-600w-2241229299.jpg",
            Type = CharacterTypes.Human,
            CharacterStats = new List<CharacterStat>
            {
                new CharacterStat { Stat = Stats.HP, Value = 100 },
                new CharacterStat { Stat = Stats.K_ATK, Value = 100 },
                new CharacterStat { Stat = Stats.K_DEF, Value = 100 },
                new CharacterStat { Stat = Stats.E_ATK, Value = 100 },
                new CharacterStat { Stat = Stats.E_DEF, Value = 100 },
                new CharacterStat { Stat = Stats.SPD, Value = 100 },
            },
            Skills = new List<Skill> { Skills.BasicAttack, Skills.Stun },
            Passives = new List<Passive> { Passives.DoubleMaxHP },
        };

        public static readonly List<Character> List = new List<Character>
        {
            SwordMan
        };
    }
}

using InfinityBox.Domain.Entities;

namespace InfinityBox.Infrastructure.SeedData
{
    public static class CharacterTypes
    {
        public static readonly CharacterType Human = new CharacterType
        {
            Id = 1,
            Name = "Human",
            Description = "We're humans"
        };

        public static readonly List<CharacterType> List = new List<CharacterType>
        {
            Human
        };
    }
}

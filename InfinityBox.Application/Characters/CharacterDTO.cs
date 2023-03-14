using InfinityBox.Domain.Entities;

namespace InfinityBox.Application.Characters;

public record CharacterDTO
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public int BaseExperience { get; set; }
    public string ImageUrl { get; set; }
    public CharacterType Type { get; set; }

    public Dictionary<string, int> Stats { get; set; }
}

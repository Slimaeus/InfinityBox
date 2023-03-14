using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Character : BaseNameEntity
{
    public int BaseExperience { get; set; }
    public string ImageUrl { get; set; }
    public Rarity Rarity { get; set; }
    public CharacterType Type { get; set; }

    public ICollection<CharacterStat> CharacterStats { get; set; }
    public ICollection<Evolution> Evolutions { get; set; }
    public ICollection<Passive> Passives { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<UserCharacter> UserCharacters { get; set; }
}

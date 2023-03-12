using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Character : BaseNameEntity
{
    public CharacterType Type { get; set; }
    public int BaseExperience { get; set; }
    public string ImageUrl { get; set; }

    public ICollection<CharacterStat> CharacterStats { get; set; }
    public ICollection<Evolution> Evolutions { get; set; }
    public ICollection<Passive> Passives { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<UserCharacter> UserCharacters { get; set; }
}

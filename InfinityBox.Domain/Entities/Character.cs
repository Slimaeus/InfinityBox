using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Character : BaseEntity
{
    public CharacterType Type { get; set; }
    public int BaseExperience { get; set; }
    public ICollection<Skill> Skills { get; set; }
    public ICollection<Passive> Passives { get; set; }
    public ICollection<Stat> Stats { get; set; }
    public ICollection<Evolution> Evolutions { get; set; }
}

using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class Character : BaseEntity
{
    public CharacterType Type { get; set; }
    public List<Skill> Skills { get; set; }
    public List<Effect> PassiveEffects { get; set; }
    public List<Stat> Stats { get; set; }
}

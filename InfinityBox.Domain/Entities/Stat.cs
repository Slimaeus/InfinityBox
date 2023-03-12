using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Stat : BaseNameEntity
{
    public CharacterStatType Type { get; set; }

    public ICollection<CharacterStat> CharacterStats { get; set; }
}

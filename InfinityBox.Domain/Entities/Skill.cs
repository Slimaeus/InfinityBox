using InfinityBox.Domain.Common;
using InfinityBox.Domain.Enums;

namespace InfinityBox.Domain.Entities;

public class Skill : BaseNameEntity
{
    public int Cooldown { get; set; }
    public int Power { get; set; }
    public int Cost { get; set; }

    public ICollection<Effect> Effects { get; set; }
}

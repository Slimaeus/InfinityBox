using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class UserCharacter : BaseGuidEntity
{
    public Guid UserId { get; set; }
    public int Level { get; set; }
    public int Stars { get; set; }
    public int Experience { get; set; }
    public List<Stat> Stats { get; set; }
    public int CharacterId { get; set; }
    public Character Character { get; set; }
    public Evolution Evolution { get; set; }

    public int CalculateExperienceRequiredToLevelUp()
        => (int)Math.Floor(Character.BaseExperience * Math.Pow(Level, 1.2) * (1 + 1.2));
}

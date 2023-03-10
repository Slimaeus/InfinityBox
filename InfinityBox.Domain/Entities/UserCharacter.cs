namespace InfinityBox.Domain.Entities;

public class UserCharacter
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public int Level { get; set; }
    public int Stars { get; set; }
    public int RequiredExperience { get; set; }
    public int Experience { get; set; }
    public List<Stat> Stats { get; set; }
    public Guid CharacterId { get; set; }
    public Character Character { get; set; }
}

namespace InfinityBox.Domain.Entities;

public class CharacterStat
{
    public int StatId { get; set; }
    public Stat Stat { get; set; }
    public int CharacterId { get; set; }
    public Character Character { get; set; }
    public int Value { get; set; }
}

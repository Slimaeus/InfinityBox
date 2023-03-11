namespace InfinityBox.Domain.Common;
public abstract class BaseEntity<TKey>
{
    public TKey Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}

public abstract class BaseEntity : BaseEntity<int> { }

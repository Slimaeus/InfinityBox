namespace InfinityBox.Domain.Common;

public class BaseNameEntity<TKey> : BaseEntity<TKey>
{
    public string Name { get; set; }
    public string Description { get; set; }
}

public class BaseNameEntity : BaseNameEntity<int> { }

namespace InfinityBox.Domain.Common;
public abstract class BaseEntity<TKey> : IBaseEntity<TKey>
{
    public virtual TKey Id { get; set; }
}

public abstract class BaseEntity : BaseEntity<int> { }
public abstract class BaseGuidEntity : BaseEntity<Guid>
{
    public override Guid Id { get => Guid.NewGuid() ; set => base.Id = value; }
}

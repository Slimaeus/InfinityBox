namespace InfinityBox.Domain.Common
{
    public interface IBaseEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
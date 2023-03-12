using InfinityBox.Domain.Common;

namespace InfinityBox.Domain.Entities;

public class UserPocket : BaseGuidEntity
{
    public Guid UserId { get; set; }
    public int Coins { get; set; }
}

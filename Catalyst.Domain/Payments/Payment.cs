using Catalyst.Domain.Common;

namespace Catalyst.Domain.Payments;
public class Payment : BaseEntity
{
    private Payment() { }
    public Payment(Guid membershipId, DateTime payedAt, decimal amount)
    {
        MembershipId = membershipId;
        PayedAt = payedAt;
        Amount = amount;
    }
    public Guid MembershipId { get; private set; }
    public DateTime PayedAt { get; private set; }
    public decimal Amount { get; private set; }
}

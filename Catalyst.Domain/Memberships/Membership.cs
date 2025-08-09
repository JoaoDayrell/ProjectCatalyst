using Catalyst.Domain.Common;


namespace Catalyst.Domain.Memberships;
public class Membership : BaseEntity
{
    private Membership() { }
    public Membership(Guid userId, Guid associationId, Guid planId, DateTime joinedAt)
    {
        UserId = userId;
        AssociationId = associationId;
        PlanId = planId;
        JoinedAt = joinedAt;
    }

    public Guid UserId { get; private set; }
    public Guid AssociationId { get; private set; }
    public Guid PlanId { get; private set; }
    public DateTime JoinedAt { get; private set; }
}

using Catalyst.Domain.Common;

namespace Catalyst.Domain.Plans;
public class Plan : BaseEntity
{
    private readonly List<PlanValue> _values = new();

    public Plan(string name, bool isDefault)
    {
        Name = name;
        IsDefault = isDefault;
    }

    private Plan() { }
    

    public string Name { get; private set; } = default!;
    public bool IsDefault { get; private set; }
    public IReadOnlyCollection<PlanValue> Values => _values;

    public void AddValue(int durationInDays, decimal price)
    {        
        _values.Add(new PlanValue(durationInDays, price));
    }
}

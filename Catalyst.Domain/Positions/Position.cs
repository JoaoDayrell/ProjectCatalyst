using Catalyst.Domain.Common;

namespace Catalyst.Domain.Positions;
public class Position : BaseEntity
{
    private Position() { }
    public Position(string name) => Name = name;
    public string Name { get; private set; } = default!;
}

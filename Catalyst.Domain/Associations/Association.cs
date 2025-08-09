using Catalyst.Domain.Common;

namespace Catalyst.Domain.Associations;
public class Association : BaseEntity
{
    private Association() { }
    public Association(string name) => Name = name;
    public string Name { get; private set; } = default!;
}

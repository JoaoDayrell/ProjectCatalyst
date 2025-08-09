using Catalyst.Domain.Common;

namespace Catalyst.Domain.Roles
{
    public class Role : BaseEntity
    {
        private Role() { }

        public Role(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }

    }
}

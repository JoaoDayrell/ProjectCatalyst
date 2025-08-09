using Catalyst.Domain.Common;

namespace Catalyst.Domain.Users
{
    public class User : BaseEntity
    {
        private User() { }
        public User(string email, string name, string? individualTaxPayerRegistration, DateTime birthDate, string passWordHash, UserStatus status)
        {
            Email = email;
            Name = name;
            IndividualTaxPayerRegistration = individualTaxPayerRegistration;
            BirthDate = birthDate;
            PasswordHash = passWordHash;
            Status = status;
        }

        public string Email { get; private set; }
        public string Name { get; private set; }
        public string? IndividualTaxPayerRegistration { get; private set; }
        public DateTime BirthDate { get; private set; }
        public string PasswordHash { get; private set; }
        public UserStatus Status { get; private set; }

        public void Block() => Status = UserStatus.Blocked;
        public void Deactivate() => Status = UserStatus.Inactive;
        public void Activate() => Status = UserStatus.Active;

        public void SetPasswordHash(string hash) => PasswordHash = hash;

        public bool ValidatePassword (string hash) => PasswordHash == hash;


    }
}

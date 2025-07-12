
namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    public class AccountService
    {
        public Staff Create(Person person)
        {
            var mail = $"{person.FirstName.ToLower()}.{person.LastName.ToLower()}@{person.Role.ToString().ToLower()}.com";
            return new Staff
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = mail,
                Role = person.Role
            };
        }
    }
}

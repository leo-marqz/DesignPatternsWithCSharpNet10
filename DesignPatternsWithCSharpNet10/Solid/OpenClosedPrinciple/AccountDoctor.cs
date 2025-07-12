
namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    public class AccountDoctor : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            return new Staff
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName.ToLower()}.{applicant.LastName.ToLower()}@doctor.com",
                Role = Role.Doctor
            };
        }
    }
}

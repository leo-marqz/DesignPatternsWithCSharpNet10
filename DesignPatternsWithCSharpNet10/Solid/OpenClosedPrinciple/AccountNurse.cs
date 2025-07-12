
namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    internal class AccountNurse : IAccountService
    {
        public Staff Create(IApplicant applicant)
        {
            return new Staff
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = $"{applicant.FirstName.ToLower()}.{applicant.LastName.ToLower()}@nurse.com",
                Role = Role.Nurse
            };
        }
    }
}


namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    internal class Nurse : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountNurse();
    }
}

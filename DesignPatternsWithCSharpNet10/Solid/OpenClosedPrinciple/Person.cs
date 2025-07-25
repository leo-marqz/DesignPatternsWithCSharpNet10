﻿
namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    public class Person : IApplicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccountService Processor { get; set; } = new AccountService();
    }
}

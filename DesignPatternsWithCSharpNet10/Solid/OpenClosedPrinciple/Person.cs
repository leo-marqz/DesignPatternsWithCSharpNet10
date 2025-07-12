﻿
namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Role Role { get; set; } = Role.Staff;
    }
}

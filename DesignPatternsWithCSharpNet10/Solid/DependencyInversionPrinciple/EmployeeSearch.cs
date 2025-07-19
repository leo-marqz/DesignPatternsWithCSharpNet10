
using System;

namespace DesignPatternsWithCSharpNet10.Solid.DependencyInversionPrinciple
{
    public class EmployeeSearch
    {
        private readonly IEmployeeSearcheable _searcheable;

        public EmployeeSearch(IEmployeeSearcheable searcheable)
        {
            _searcheable = searcheable;
        }

        public int GetMaleExecutives()
        {
            return _searcheable.GetEmployeeGenderAndRole(
                    gender: Gender.Male, 
                    role: Role.Executive
                );
        }
    }
}

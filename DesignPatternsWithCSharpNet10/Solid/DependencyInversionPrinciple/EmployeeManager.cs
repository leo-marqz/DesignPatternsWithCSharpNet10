
using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsWithCSharpNet10.Solid.DependencyInversionPrinciple
{
    public class EmployeeManager : IEmployeeSearcheable
    {
        private readonly List<Employee> _employees;

        public EmployeeManager()
        {
            _employees = new List<Employee>();
        }

        public int GetEmployeeGenderAndRole(Gender gender, Role role)
        {
            return _employees
                        .Where((x)=>x.Role == role && x.Gender == gender)
                        .ToList()
                        .Count();
        }

        public void Save(Employee employee)
        {
            _employees.Add(employee);
        }
    }
}

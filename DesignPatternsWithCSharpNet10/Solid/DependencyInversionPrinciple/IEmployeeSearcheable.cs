
namespace DesignPatternsWithCSharpNet10.Solid.DependencyInversionPrinciple
{
    public interface IEmployeeSearcheable
    {
        int GetEmployeeGenderAndRole(Gender gender, Role role);
    }
}

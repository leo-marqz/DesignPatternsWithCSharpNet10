

namespace DesignPatternsWithCSharpNet10.Solid.LiskovSubstitutionPrinciple
{
    public interface IPlayer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        PlayerCategory Category { get; set; }
    }
}

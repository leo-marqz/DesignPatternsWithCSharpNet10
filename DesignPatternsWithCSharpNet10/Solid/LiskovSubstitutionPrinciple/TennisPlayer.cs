
namespace DesignPatternsWithCSharpNet10.Solid.LiskovSubstitutionPrinciple
{
    public class TennisPlayer : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
    }
}

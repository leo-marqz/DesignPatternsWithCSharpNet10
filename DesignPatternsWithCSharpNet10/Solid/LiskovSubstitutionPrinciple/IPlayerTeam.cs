
namespace DesignPatternsWithCSharpNet10.Solid.LiskovSubstitutionPrinciple
{
    public interface IPlayerTeam : IPlayer
    {
        Team Team { get; set; }
    }
}

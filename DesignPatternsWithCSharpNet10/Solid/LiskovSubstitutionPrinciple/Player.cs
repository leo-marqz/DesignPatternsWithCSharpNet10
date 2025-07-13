
namespace DesignPatternsWithCSharpNet10.Solid.LiskovSubstitutionPrinciple
{
    //DEPRECATED
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Team Team { get; set; }
        public PlayerCategory Category { get; set; }
        public string GetTeam { get => Team.Name; }
        public virtual void AssignTeam(Team team)
        {
            Team = team;
        }
        public virtual void SetCategory(PlayerCategory category)
        {
            Category = category;
        }
    }
}

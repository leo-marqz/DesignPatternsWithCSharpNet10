
namespace DesignPatternsWithCSharpNet10.Solid.LiskovSubstitutionPrinciple
{
    public class FootballPlayer : IPlayer, IPlayerTeam
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public PlayerCategory Category { get; set; }
        public Team Team { get; set; }

        public int GetMarketValueByCategoryPlayer()
        {
            int value = 0;
            switch (Category)
            {
                case PlayerCategory.Amateur:
                    value = 100;
                    break;
                case PlayerCategory.Profesional:
                    value = 1_000;
                    break;
                default:
                    value = 100;
                    break;
            }
            return value;
        }
    }
}

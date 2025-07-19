
namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Builder
{
    public class SandwichAssembly
    {
        private SandwichBuilder _sandwichBuilder;

        public SandwichAssembly(SandwichBuilder sandwichBuilder)
        {
            _sandwichBuilder = sandwichBuilder;
        }

        public void Assemble()
        {
            _sandwichBuilder.AddBread();
            _sandwichBuilder.AddCheese();
            _sandwichBuilder.AddProtein();
            _sandwichBuilder.AddVeggies();
            _sandwichBuilder.AddCondiments();
        }

        public Sandwich GetSandwich { get { return _sandwichBuilder.Sandwich; } }
    }
}

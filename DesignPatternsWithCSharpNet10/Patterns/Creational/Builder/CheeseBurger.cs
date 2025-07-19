
namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Builder
{
    //CONCRETE
    public class CheeseBurger : SandwichBuilder
    {
        public CheeseBurger()
        {
            _sandwich = new Sandwich();
            _sandwich.Type = this.GetType().Name;
        }

        public override void AddBread()
        {
            _sandwich.Bread = "Pan Frica";
        }

        public override void AddCheese()
        {
            _sandwich.Cheese = "Queso Cheedar";
        }

        public override void AddCondiments()
        {
            _sandwich.Condiments = "Mayonesa";
        }

        public override void AddProtein()
        {
            _sandwich.Protein = "Carne de Res";
        }

        public override void AddVeggies()
        {
            _sandwich.Veggies = "";
        }
    }
}

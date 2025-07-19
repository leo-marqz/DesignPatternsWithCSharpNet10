
namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Builder
{
    public class ChickenAvocadoSandwich : SandwichBuilder
    {
        public ChickenAvocadoSandwich()
        {
            _sandwich = new Sandwich();
            _sandwich.Type = this.GetType().Name;
        }

        public override void AddBread()
        {
            _sandwich.Bread = "Pan Integral Artesanal";
        }

        public override void AddCheese()
        {
            _sandwich.Cheese = "Queso Suave Mozzarella";
        }

        public override void AddCondiments()
        {
            _sandwich.Condiments = "Mostaza Dijon y un toque de ajo cremoso";
        }

        public override void AddProtein()
        {
            _sandwich.Protein = "Pechuga de Pollo a la Parrilla";
        }

        public override void AddVeggies()
        {
            _sandwich.Veggies = "Rodajas de Aguacate, Lechuga Romana y Tomate";
        }
    }
}


namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise
{
    public class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            Name = "Pepperoni";
            Dough = "Delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso Mozarella");
        }
    }
}

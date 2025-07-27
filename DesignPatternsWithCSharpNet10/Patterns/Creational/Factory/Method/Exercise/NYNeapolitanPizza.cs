
namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise
{
    public class NYNeapolitanPizza : Pizza
    {
        public NYNeapolitanPizza()
        {
            Name = "Neapolitan";
            Dough = "Delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso Mozarella");
        }
    }
}

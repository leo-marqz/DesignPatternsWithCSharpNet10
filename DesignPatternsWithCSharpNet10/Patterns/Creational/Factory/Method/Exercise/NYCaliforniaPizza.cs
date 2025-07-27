
namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise
{
    public class NYCaliforniaPizza : Pizza
    {
        public NYCaliforniaPizza()
        {
            Name = "California";
            Dough = "Delgada";
            Sauce = "Salsa de tomates";
            Toppings.Add("Quesso Mozarella");
        }
    }
}

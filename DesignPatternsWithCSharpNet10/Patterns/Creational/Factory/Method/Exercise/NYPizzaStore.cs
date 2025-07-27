
using System;

namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(TypeOfPizza type)
        {
            return (Pizza) Activator
                .CreateInstance(
                Type.GetType(
                    $"DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise.NY{Enum.GetName(typeof(TypeOfPizza), type)}Pizza"
                    )
                );
        }
    }
}

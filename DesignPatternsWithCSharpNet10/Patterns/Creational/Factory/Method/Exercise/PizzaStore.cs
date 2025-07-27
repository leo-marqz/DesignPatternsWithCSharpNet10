﻿
namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise
{
    public  abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(TypeOfPizza type);

        public Pizza OrderPizza(TypeOfPizza type)
        {
            Pizza pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}

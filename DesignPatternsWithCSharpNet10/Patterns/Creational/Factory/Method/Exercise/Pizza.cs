
using System;
using System.Collections.Generic;

namespace DesignPatternsWithCSharpNet10.Patterns.Creational.Factory.Method.Exercise
{
    public class Pizza
    {
        public string Name { get; set; }
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparando: {Name}");
            Console.WriteLine($"Colocando masa: {Dough}");
            Console.WriteLine($"Agregando salsa: {Sauce}");
            Console.WriteLine($"Agregando capas: {string.Join(",", Toppings)}");
        }

        public void Bake() => Console.WriteLine("Cocinar por 20 minutos...");
        public void Cut() => Console.WriteLine("Pizza fue cortada en partes iguales");
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple.Exercise
{
    public class Circle : IShape
    {
        public double Radius { get; set; }

        public double Area()
        {
            return (double) (Radius * Radius * Math.PI);
        }
    }
}

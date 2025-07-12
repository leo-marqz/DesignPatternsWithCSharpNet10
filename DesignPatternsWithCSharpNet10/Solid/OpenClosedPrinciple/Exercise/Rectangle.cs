
namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple.Exercise
{
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Heigh { get; set; }

        public double Area()
        {
            return (double) (Width * Heigh);
        }
    }
}

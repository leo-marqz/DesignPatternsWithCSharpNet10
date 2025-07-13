

namespace DesignPatternsWithCSharpNet10.Solid.InterfaceSegregationPrinciple
{
    public class HPMinimalPrinter : IPrint, IScan
    {
        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public void Scan()
        {
            throw new System.NotImplementedException();
        }

        public void SetDocumentFormat(DocumentFormat format)
        {
            throw new System.NotImplementedException();
        }
    }
}

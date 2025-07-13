using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsWithCSharpNet10.Solid.InterfaceSegregationPrinciple
{
    public interface IPrint
    {
        void SetDocumentFormat(DocumentFormat format);
        void Print();
    }
}


using System.Collections.Generic;
using System.Linq;

namespace DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple
{
    public class ValidatorResult
    {
        public List<string> Errors { get; set; } = new List<string>();
        public bool IsValid { get => !Errors.Any(); }
    }
}

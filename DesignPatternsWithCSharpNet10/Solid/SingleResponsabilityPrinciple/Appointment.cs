
using System;

namespace DesignPatternsWithCSharpNet10.Solid.SingleResponsabilityPrinciple
{
    public class Appointment
    {
        public Patient Patient { get; set; }
        public DateTime Date { get; set; }
    }
}

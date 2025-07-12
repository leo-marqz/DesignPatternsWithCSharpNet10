
using System.ComponentModel.DataAnnotations;

namespace DesignPatternsWithCSharpNet10.Solid.OpenClosedPrinciple
{
    public enum Role
    {
        [Display(Name = "Doctor")]
        Doctor = 0,

        [Display(Name = "Nurse | Enfermera")]
        Nurse = 1,

        [Display(Name = "Staff | Empleado")]
        Staff = 2,

        [Display(Name = "Software Engineer")]
        SoftwareEngineer = 3
    }
}

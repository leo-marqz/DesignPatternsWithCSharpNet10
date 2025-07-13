
using System.ComponentModel.DataAnnotations;

namespace DesignPatternsWithCSharpNet10.Solid.LiskovSubstitutionPrinciple
{
    public enum PlayerCategory
    {
        [Display(Name = "Amateur | Principiante")]
        Amateur,

        [Display(Name = "Profesional")]
        Profesional
    }
}

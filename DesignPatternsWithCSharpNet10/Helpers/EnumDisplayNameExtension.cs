
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace DesignPatternsWithCSharpNet10.Helpers
{
    public static class EnumDisplayNameExtension
    {
        public static string GetDisplayName(this Enum value)
        {
            return value.GetType()
                        .GetMember(value.ToString())[0]
                        .GetCustomAttributes<DisplayAttribute>()
                        .FirstOrDefault()?.Name ?? value.ToString();
        }
    }
}

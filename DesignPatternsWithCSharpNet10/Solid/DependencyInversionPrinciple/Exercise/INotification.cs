
using System.Threading.Tasks;

namespace DesignPatternsWithCSharpNet10.Solid.DependencyInversionPrinciple.Exercise
{
    public interface INotification
    {
        Task SendAsync();
    }
}


using System.Threading.Tasks;

namespace DesignPatternsWithCSharpNet10.Solid.InterfaceSegregationPrinciple
{
    public interface IFax
    {
        Task SendFaxAsync(string recipientNumber);
    }
}

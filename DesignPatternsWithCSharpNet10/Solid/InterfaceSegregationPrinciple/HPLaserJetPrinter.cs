
using System.Threading.Tasks;

namespace DesignPatternsWithCSharpNet10.Solid.InterfaceSegregationPrinciple
{
    public class HPLaserJetPrinter : IPrint, IScan, IFax, IWifi
    {
        public void ConnectWifi()
        {
            throw new System.NotImplementedException();
        }

        public void DisconnectWifi()
        {
            throw new System.NotImplementedException();
        }

        public bool IsWifiConnected()
        {
            throw new System.NotImplementedException();
        }

        public void Print()
        {
            throw new System.NotImplementedException();
        }

        public void Scan()
        {
            throw new System.NotImplementedException();
        }

        public Task SendFaxAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task SendFaxAsync(string recipientNumber)
        {
            throw new System.NotImplementedException();
        }

        public void SetDocumentFormat(DocumentFormat format)
        {
            throw new System.NotImplementedException();
        }
    }
}

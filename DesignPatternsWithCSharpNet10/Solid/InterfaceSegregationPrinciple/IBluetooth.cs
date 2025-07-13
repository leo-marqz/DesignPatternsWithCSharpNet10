

namespace DesignPatternsWithCSharpNet10.Solid.InterfaceSegregationPrinciple
{
    public interface IBluetooth
    {
        void ConnectBluetooth();
        bool IsBluetoothConnected();
        void DisconnectBluetooth();
    }
}

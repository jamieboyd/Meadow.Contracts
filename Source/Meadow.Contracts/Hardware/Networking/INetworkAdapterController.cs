namespace Meadow.Hardware
{
    public interface INetworkAdapterController
    {
        event NetworkConnectionHandler NetworkConnected;
        event NetworkDisconnectionHandler NetworkDisconnected;

        INetworkAdapterCollection NetworkAdapters { get; }
    }
}

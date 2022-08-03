using System.Net;
using System.Net.NetworkInformation;

namespace Meadow.Hardware
{
    public delegate void NetworkConnectionHandler(INetworkAdapter sender, NetworkConnectionEventArgs args);
    public delegate void NetworkDisconnectionHandler(INetworkAdapter sender);

    public interface INetworkAdapter
    {
        event NetworkConnectionHandler NetworkConnected;
        event NetworkDisconnectionHandler NetworkDisconnected;

        /// <summary>
        /// Indicate if the network adapter is connected to an access point.
        /// </summary>
        bool IsConnected { get; }

        /// <summary>
        /// IP Address of the network adapter.
        /// </summary>
        IPAddress IpAddress { get; }

        /// <summary>
        /// Subnet mask of the adapter.
        /// </summary>
        IPAddress SubnetMask { get; }

        /// <summary>
        /// Default gateway for the adapter.
        /// </summary>
        IPAddress Gateway { get; }

        /// <summary>
        /// Physical (MAC) address of the adapter
        /// </summary>
        PhysicalAddress MacAddress { get; }
    }
}

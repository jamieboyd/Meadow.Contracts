using System.Net;

namespace Meadow.Hardware;

/// <summary>
/// Data relating to a Ethernet connection.
/// </summary>
public class EthernetNetworkConnectionEventArgs : NetworkConnectionEventArgs
{
    /// <summary>
    /// Construct a EthernetNetworkConnectionEventArgs request.
    /// </summary>
    /// <param name="ipAddress">IP address of the device.</param>
    /// <param name="subnet">Subnet of the device.</param>
    /// <param name="gateway">Gateway address of the device.</param>
    public EthernetNetworkConnectionEventArgs(IPAddress ipAddress, IPAddress subnet, IPAddress gateway)
        : base(ipAddress, subnet, gateway)
    {
    }
}

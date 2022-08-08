using System;
using System.Net;

namespace Meadow.Hardware
{
    public class NetworkConnectionEventArgs : EventArgs
    {
        /// <summary>
        /// IP address of the device on the network.
        /// </summary>
        public IPAddress IpAddress { get; }

        /// <summary>
        /// Subnet mask of the device.
        /// </summary>
        public IPAddress Subnet { get; }

        /// <summary>
        /// Address of the gateway.
        /// </summary>
        public IPAddress Gateway { get; }

        public NetworkConnectionEventArgs(IPAddress ipAddress, IPAddress subnet, IPAddress gateway)
        {
            IpAddress = ipAddress;
            Subnet = subnet;
            Gateway = gateway;
        }
    }
}

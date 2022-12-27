using System;
using System.Net;

namespace Meadow.Hardware
{
    /// <summary>
    /// Event arguments for the NodeConnected and NodeDisconnected events.
    /// </summary>
    public class NodeConnectionChangeEventArgs : EventArgs
    {
        /// <summary>
        /// Date and time the event was generated.
        /// </summary>
        public DateTime When { get; private set; }

        /// <summary>
        /// MAC address of the node joining or leaving the network.
        /// </summary>
        public byte[] MacAddress { get; }

        /// <summary>
        /// IP address of a node, this is IPAddress.None if a node is disconnecting from the access point.
        /// </summary>
        public IPAddress IpAddress { get; }

        /// <summary>
        /// Create a new NodeConnectionChangeEventArgs object.
        /// </summary>
        /// <param name="mac">MAC address of the node connecting / disconnecting.</param>
        /// <param name="ip">IP address of a connecting node.</param>
        public NodeConnectionChangeEventArgs(byte[] mac, IPAddress ip)
        {
            MacAddress = new byte[mac.Length];
            Array.Copy(mac, MacAddress, mac.Length);
            IpAddress = ip;
            When = DateTime.Now;
        }
    }
}

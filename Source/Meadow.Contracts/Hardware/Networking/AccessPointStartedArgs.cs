using System;
using System.Net;

namespace Meadow.Hardware
{
    /// <summary>
    /// Provide information about a change of state for the access point.
    /// </summary>
	public class AccessPointStartedArgs : EventArgs
    {
        /// <summary>
        /// Date and time the event was generated.
        /// </summary>
        public DateTime When { get; private set; }

        /// <summary>
        /// First IP address in the DHCP server range.
        /// </summary>
        public IPAddress DHCPServerIPAddress{ get; private set; }

        /// <summary>
        /// Subnet mask used by the DHCP server.
        /// </summary>
        public IPAddress DHCPServerSubnetMask { get; private set; }

        /// <summary>
        /// Gateway address used by the DHCP server.
        /// </summary>
        public IPAddress DHCPServerGateway { get; private set; }

        /// <summary>
        /// Create a new AccessPointStateChangeEventArgs object.
        /// </summary>
        public AccessPointStartedArgs(IPAddress dhcpIpAddress, IPAddress dhcpSubnetMask, IPAddress dhcpGateway)
		{
            When = DateTime.Now;
            DHCPServerIPAddress = dhcpIpAddress;
            DHCPServerSubnetMask = dhcpSubnetMask;
            DHCPServerGateway = dhcpGateway;
		}
	}
}

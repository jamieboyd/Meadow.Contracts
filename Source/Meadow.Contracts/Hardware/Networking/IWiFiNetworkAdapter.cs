using Meadow.Gateway.WiFi;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;

namespace Meadow.Hardware
{
    /// <summary>
    /// Delegate containing information about a access point start event.
    /// </summary>
    /// <param name="sender">Object raising the event.</param>
    /// <param name="args">Information about the change in state of the access point.</param>
    public delegate void AccessPointStartedHandler(INetworkAdapter sender, AccessPointStateChangeArgs args);

    /// <summary>
    /// Delegate containing information about a access point stop event.
    /// </summary>
    /// <param name="sender">Object raising the event.</param>
    /// <param name="args">Information about the change in state of the access point.</param>
    public delegate void AccessPointStoppedHandler(INetworkAdapter sender, AccessPointStateChangeArgs args);

    /// <summary>
    /// Delegate containing information about a new node joining the access point.
    /// </summary>
    /// <param name="sender">Object raising the event.</param>
    /// <param name="args">Information about the node connecting to the access point.</param>
    public delegate void NodeConnectedHandler(INetworkAdapter sender, NodeConnectionChangeEventArgs args);

    /// <summary>
    /// Delegate containing information about a new node leaving the access point.
    /// </summary>
    /// <param name="sender">Object raising the event.</param>
    /// <param name="args">Information about the node disconnecting from the access point.</param>
    public delegate void NodeDisconnectedHandler(INetworkAdapter sender, NodeConnectionChangeEventArgs args);

    /// <summary>
    /// Defaine the IWiFiNetworkAdapter interface.
    /// </summary>
    public interface IWiFiNetworkAdapter : IWirelessNetworkAdapter
    {
        /// <summary>
        /// Event raised when the access point has started.
        /// </summary>
        event AccessPointStartedHandler AccessPointStarted;

        /// <summary>
        /// Event raised when the access point has stopped.
        /// </summary>
        event AccessPointStoppedHandler AccessPointStopped;

        /// <summary>
        /// Event raied when a node connects to the access point.
        /// </summary>
        event NodeConnectedHandler NodeConnected;

        /// <summary>
        /// Event raised when a node disconnects from the access point.
        /// </summary>
        event NodeDisconnectedHandler NodeDisconnected;

        /// <summary>
        /// Access point the adapter is currently connected to
        /// </summary>
        string? Ssid { get; }

        /// <summary>
        /// BSSID (MAC) of the access point the ESP32 is currently connected to.
        /// </summary>
        PhysicalAddress Bssid { get; }

        /// <summary>
        /// Automatically attempt to connect to the <b>DefaultSsid</b> network after a power cycle or reset.
        /// </summary>
        bool AutoConnect { get; }

        /// <summary>
        /// Automatically try to reconnect to an access point if there is a problem / disconnection
        /// </summary>
        bool AutoReconnect { get; }

        /// <summary>
        /// Default access point to try to connect to if the network interface is started and the board
        /// is configured to automatically reconnect.
        /// </summary>
        string DefaultSsid { get; }

        /// <summary>
        /// WiFi channel used for communication.
        /// </summary>
        int Channel { get; }

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="timeout">Timeout period for the connection attempt</param>
        /// <param name="token">Cancellation token for the connection attempt</param>
        /// <param name="reconnection">Should the adapter reconnect automatically?</param>
        /// <exception cref="ArgumentNullException">Thrown if the ssid is null or empty or the password is null.</exception>
        Task Connect(string ssid, string password, TimeSpan timeout, CancellationToken token, ReconnectionType reconnection = ReconnectionType.Automatic);

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="reconnection">Should the adapter reconnect automatically?</param>
        /// <exception cref="ArgumentNullException">Thrown if the ssid is null or empty or the password is null.</exception>
        async Task Connect(string ssid, string password, ReconnectionType reconnection = ReconnectionType.Automatic)
        {
            var src = new CancellationTokenSource();
            await Connect(ssid, password, TimeSpan.Zero, src.Token, reconnection);
        }

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="token">Cancellation token for the connection attempt</param>
        /// <param name="reconnection">Should the adapter reconnect automatically?</param>
        /// <exception cref="ArgumentNullException">Thrown if the ssid is null or empty or the password is null.</exception>
        async Task Connect(string ssid, string password, CancellationToken token, ReconnectionType reconnection = ReconnectionType.Automatic)
        {
            var src = new CancellationTokenSource();
            await Connect(ssid, password, TimeSpan.Zero, token, reconnection);
        }

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="timeout">Timeout period for the connection attempt</param>
        /// <param name="reconnection">Should the adapter reconnect automatically?</param>
        /// <exception cref="ArgumentNullException">Thrown if the ssid is null or empty or the password is null.</exception>
        async Task Connect(string ssid, string password, TimeSpan timeout, ReconnectionType reconnection = ReconnectionType.Automatic)
        {
            var src = new CancellationTokenSource();
            await Connect(ssid, password, timeout, src.Token, reconnection);
        }

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="timeout">Timeout period for the connection attempt</param>
        /// <param name="token">Cancellation token for the connection attempt</param>
        async Task Connect(string ssid, string password, TimeSpan timeout, CancellationToken token)
        {
            await Connect(ssid, password, timeout, token, ReconnectionType.Automatic);
        }

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <param name="timeout">Timeout period for the connection attempt</param>
        async Task Connect(string ssid, string password, TimeSpan timeout)
        {
            await Connect(ssid, password, timeout, CancellationToken.None);
        }

        /// <summary>
        /// Start a WiFi network.
        /// </summary>
        /// <param name="ssid">Name of the network to connect to.</param>
        /// <param name="password">Password for the network.</param>
        /// <returns>true if the connection was successfully made.</returns>
        async Task Connect(string ssid, string password)
        {
            await Connect(ssid, password, TimeSpan.FromSeconds(90), CancellationToken.None);
        }

        /// <summary>
        /// Disconnect from the the currently active access point.
        /// </summary>
        /// <remarks>
        /// Setting turnOffWiFiInterface to true will call StopWiFiInterface following
        /// the disconnection from the current access point.
        /// </remarks>
        /// <param name="turnOffWiFiInterface">Should the WiFi interface be turned off?</param>
        Task Disconnect(bool turnOffWiFiInterface);

        /// <summary>
        /// Connect to the default access point.
        /// </summary>
        /// <remarks>The access point credentials should be stored in the coprocessor memory.</remarks>
        void ConnectToDefaultAccessPoint();

        /// <summary>
        /// Create a new access point on the ESP32 with the specified SSID and password.
        /// </summary>
        /// <remarks>
        /// The default DHCP setting will be used for the access point.
        /// </remarks>
        /// <param name="ssid">SSID for the access point.</param>
        /// <param name="password">Password for the access point.</param>
        async Task StartAccessPoint(string ssid, string password)
        {
            await StartAccessPoint(ssid, password, IPAddress.None, IPAddress.None, IPAddress.None);
        }

        /// <summary>
        /// Create a new access point on the ESP32 with the specified SSID and password.
        /// </summary>
        /// <remarks>
        /// The IP address and subnet mask must allow for 10 IP addresses.
        /// </remarks>
        /// <param name="ssid">SSID for the access point.</param>
        /// <param name="password">Password for the access point.</param>
        /// <param name="ip">IP address for the DHCP server.</param>
        /// <param name="subnet"><Subnet mask for the DHCP server./param>
        /// <param name="gateway"Default gateway for the DHCP server.></param>
        Task StartAccessPoint(string ssid, string password, IPAddress ip, IPAddress subnet, IPAddress gateway);

        /// <summary>
        /// Removed any stored access point information from the coprocessor memory.
        /// </summary>
        Task ClearStoredAccessPointInformation();

        /// <summary>
        /// Get the list of access points.
        /// </summary>
        /// <remarks>
        /// The network must be started before this method can be called.
        /// </remarks>
        /// <returns>An `IList` (possibly empty) of access points.</returns>
        public Task<IList<WifiNetwork>> Scan()
        {
            return Scan(TimeSpan.FromMilliseconds(-1));
        }

        Task<IList<WifiNetwork>> Scan(CancellationToken token);
        Task<IList<WifiNetwork>> Scan(TimeSpan timeout);
    }
}

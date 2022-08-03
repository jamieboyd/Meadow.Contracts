using Meadow.Hardware;
using System;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace Meadow.Gateways
{
    public interface IWiFiAdapter : IWirelessNetworkAdapter
    {
        #region Properties

        /// <summary>
        /// Get the network time when the WiFi adapter starts?
        /// </summary>
        bool GetNetworkTimeAtStartup { get; }

        /// <summary>
        /// MAC address of the board when acting as a sft access point.
        /// </summary>
        PhysicalAddress ApMacAddress { get; }

        /// <summary>
        /// Maximum number of times the ESP32 will retry a netowrk operation before returning an error.
        /// </summary>
        uint MaximumRetryCount { get; set; }

        /// <summary>
        /// Current antenna in use.
        /// </summary>
        AntennaType Antenna { get; }

        /// <summary>
        /// Automatically start the network interface when the board reboots?
        /// </summary>
        /// <remarks>
        /// This will automatically connect to any preconfigured access points if they are available.
        /// </remarks>
        bool AutomaticallyStartNetwork { get; }

        /// <summary>
        /// Automatically try to reconnect to an access point if there is a problem / disconnection?
        /// </summary>
        bool AutomaticallyReconnect { get; }

        /// <summary>
        /// Default access point to try to connect to if the network interface is started and the board
        /// is configured to automatically reconnect.
        /// </summary>
        string DefaultAcessPoint { get; }


        /// <summary>
        /// BSSID of the access point the ESP32 is currently connected to.
        /// </summary>
        string Bssid { get; }

        /// <summary>
        /// WiFi channel the ESP32 and the access point are using for communication.
        /// </summary>
        uint Channel { get; }

        #endregion Properties

        #region Delegates and Events

        /// <summary>
        /// User code to process the InterfaceStarted event.
        /// </summary>
        event EventHandler WiFiInterfaceStarted;

        /// <summary>
        /// User code to process the InterfaceStopped event.
        /// </summary>
        event EventHandler WiFiInterfaceStopped;

        /// <summary>
        /// User code to process the time changed event.
        /// </summary>
        event EventHandler NtpTimeChanged;

        #endregion Delegates and Events

        /// <summary>
        /// Start the network interface on the WiFi adapter.
        /// </summary>
        /// <remarks>
        /// This method starts the network interface hardware.  The result of this action depends upon the
        /// settings stored in the WiFi adapter memory.
        ///
        /// No Stored Configuration
        /// If no settings are stored in the adapter then the hardware will simply start.  IP addresses
        /// will not be obtained in this mode.
        ///
        /// In this case, the return result indicates if the hardware started successfully.
        ///
        /// Stored Configuration Present
        /// If a default access point (and optional password) are stored in the adapter then the network
        /// interface and the system is set to connect at startup then the system will then attempt to
        /// connect to the specified access point.
        ///
        /// In this case, the return result indicates if the interface was started successfully and a
        /// connection to the access point was made.
        /// </remarks>
        /// <returns>true if the adapter was started successfully, false if there was an error.</returns>
        Task<bool> StartWiFiInterface();

        /// <summary>
        /// Stop the WiFi interface,
        /// </summary>
        /// <remarks>
        /// Stopping the WiFi interface will release all resources associated with the WiFi running on the ESP32.
        /// 
        /// Errors could occur if the adapter was not started.
        /// </remarks>
        /// <returns>true if the adapter was successfully turned off, false if there was a problem.</returns>
        Task<bool> StopWiFiInterface();
    }
}
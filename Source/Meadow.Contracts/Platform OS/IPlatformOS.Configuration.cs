namespace Meadow
{
    public partial interface IPlatformOS
    {
        /// <summary>
        /// Enumeration indicating the possible configuration items that can be read / written.
        /// </summary>
        /// <remarks>It is critical that this enum matches the enum in the NuttX file hcom_nx_config_manager.h.</remarks>
        public enum ConfigurationValues
        {
            DeviceName = 0,                 // 0
            Product,                        // 1
            Model,                          // 2
            OsVersion,                      // 3
            BuildDate,                      // 4
            ProcessorType,                  // 5
            UniqueId,                       // 6
            SerialNumber,                   // 7
            CoprocessorType,                // 8
            CoprocessorFirmwareVersion,     // 9
            MonoVersion,                    // 10
            AutomaticallyStartNetwork,      // 11
            AutomaticallyReconnect,         // 12
            MaximumNetworkRetryCount,       // 13
            GetTimeAtStartup,               // 14
            MacAddress,                     // 15
            SoftApMacAddress,               // 16
            DefaultAccessPoint,             // 17
            ResetReason,                    // 18
            RebootOnUnhandledException,     // 19
            InitializationTimeout,          // 20
            SelectedNetwork,                // 21
            StaticIpAddress,                // 22
            SubnetMask,                     // 23
            DefaultGateway,                 // 24
            SdStorageSupported,             // 25
            ReservedPins                    // 26
        };

        /// <summary>
        /// Enumeration representing the available network connection types.
        /// </summary>
        public enum NetworkConnectionType
        {
            /// <summary>
            /// WiFi network connection
            /// </summary>
            WiFi = 0,
            /// <summary>
            /// Ethernet network connection
            /// </summary>
            Ethernet,
            /// <summary>
            /// Cell network connection
            /// </summary>
            Cell
        }


        /// <summary>
        /// Get a configuration value, as specified in meadow.config.yaml, from the OS.
        /// </summary>
        /// <typeparam name="T">Type of the object being retrieved.</typeparam>
        /// <param name="item">Item to retrieve.</param>
        /// <returns>Value for the specified item.</returns>
        T GetConfigurationValue<T>(ConfigurationValues item) where T : struct;

        /// <summary>
        /// Send a configuration value to the OS.
        /// </summary>
        /// <typeparam name="T">Type of the object being set.</typeparam>
        /// <param name="item">Item to set.</param>
        /// <param name="value">Value of item.</param>
        void SetConfigurationValue<T>(ConfigurationValues item, T value) where T : struct;

        // named properties

        /// <summary>
        /// OS version.
        /// </summary>
        string OSVersion { get; }

        /// <summary>
        /// OS build date and time.
        /// </summary>
        string OSBuildDate { get; }

        /// <summary>
        /// .NET Runtime version install on the device.
        /// </summary>
        string RuntimeVersion { get; }

        /// <summary>
        /// Should the system rebot on an exception?
        /// </summary>
        bool RebootOnUnhandledException { get; }

        /// <summary>
        /// Number of seconds allowed for the system to initialize.
        /// </summary>
        uint InitializationTimeout { get; }

        /// <summary>
        /// Should a WiFi connection be made on startup.
        /// </summary>
        /// <remarks>This assumes that the default access point is configured through wifi.config.yaml.</remarks>
        bool AutomaticallyStartNetwork { get; }

        /// <summary>
        /// Which network is selected in meadow.config.yaml.
        /// </summary>
        public NetworkConnectionType SelectedNetwork { get; }

        /// <summary>
        /// Should SD card support be enabled on this platform?
        /// </summary>
        public bool SdStorageSupported { get; }

        /// <summary>
        /// Names of any pins that should be reserved for OS use.
        /// </summary>
        /// <remarks>This should be a semicolon list of pin names that will be reserved for OS use.</remarks>
        public string ReservedPins { get; }
    }
}

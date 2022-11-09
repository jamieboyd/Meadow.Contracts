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
            DeviceName = 0,
            Product,
            Model,
            OsVersion,
            BuildDate,
            ProcessorType,
            UniqueId,
            SerialNumber,
            CoprocessorType,
            CoprocessorFirmwareVersion,
            MonoVersion,
            AutomaticallyStartNetwork,
            AutomaticallyReconnect,
            MaximumNetworkRetryCount,
            GetTimeAtStartup,
            MacAddress,
            SoftApMacAddress,
            DefaultAccessPoint,
            ResetReason,
            RebootOnUnhandledException,
            InitializationTimeout,
            SdCardPresent,
            SelectedNetwork,
            StaticIpAddress,
            SubnetMask,
            DefaultGateway
        };

        /// <summary>
        /// Network connection types available.
        /// </summary>
        public enum NetworkConnectionType
        {
            WiFi = 0,
            Ethernet,
            GSM
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
        void SetConfigurationValue<T>(ConfigurationValues item, T value) where T : struct;

        // named properties

        /// <summary>
        /// OS veriosn.
        /// </summary>
        string OSVersion { get; }

        /// <summary>
        /// OS build date and time.
        /// </summary>
        string OSBuildDate { get; }

        /// <summary>
        /// Mono version install on the device.
        /// </summary>
        string MonoVersion { get; }

        /// <summary>
        /// Should the system rebot on an exception?
        /// </summary>
        bool RebootOnUnhandledException { get; }

        /// <summary>
        /// Number of seconds allowed for the system to initialize.
        /// </summary>
        uint InitializationTimeout { get; }

        /// <summary>
        /// Is an SD card on the device.
        /// </summary>
        bool SdCardPresent { get; }

        /// <summary>
        /// Should a WiFi connection be made on startup.
        /// </summary>
        /// <remarks>This assumes that the default access point is configured through wifi.config.yaml.</remarks>
        bool AutomaticallyStartNetwork { get; }

        /// <summary>
        /// Which network is selected in meadow.config.yaml.
        /// </summary>
        public NetworkConnectionType SelectedNetwork { get; }
    }
}

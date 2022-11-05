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
            SelectedNetwork
        };

        public enum NetworkConnectionType
        {
            WiFi = 0,
            Ethernet,
            GSM
        }

        T GetConfigurationValue<T>(ConfigurationValues item) where T : struct;

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

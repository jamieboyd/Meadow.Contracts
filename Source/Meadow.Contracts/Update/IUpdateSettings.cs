namespace Meadow.Update
{
    /// <summary>
    /// Provides an abstraction for settings passed to the Meadow Update Service
    /// </summary>
    public interface IUpdateSettings
    {
        /// <summary>
        /// Gets the desired enabled state of the service
        /// </summary>
        public bool Enabled { get; }
        /// <summary>
        /// Gets the address of the Update server to use
        /// </summary>
        public string UpdateServer { get; }
        /// <summary>
        /// Gets the port of the Update server to use
        /// </summary>
        public int UpdatePort { get; }
        /// <summary>
        /// Gets the root MQTT topic to subscribe to for updates
        /// </summary>
        public string RootTopic { get; }
        /// <summary>
        /// Reconnect period used when a disconnection from the Update server occrs
        /// </summary>
        public int CloudConnectRetrySeconds { get; }
    }
}
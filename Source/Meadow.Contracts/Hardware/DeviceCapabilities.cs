namespace Meadow
{
    /// <summary>
    /// A set of capabilities of the current Device
    /// </summary>
    public class DeviceCapabilities
    {
        /// <summary>
        /// Network capabilities of the current Device
        /// </summary>
        public NetworkCapabilities Network { get; protected set; }
        /// <summary>
        /// Analog I/O capabilities of the current Device
        /// </summary>
        public AnalogCapabilities Analog { get; protected set; }
        /// <summary>
        /// Storage capabilities of the current Device
        /// </summary>
        public StorageCapabilities Storage { get; protected set; }

        /// <summary>
        /// Creates an instance of a DeviceCapabilities class
        /// </summary>
        /// <param name="analog"></param>
        /// <param name="network"></param>
        /// <param name="storage"></param>
        public DeviceCapabilities(
            AnalogCapabilities analog,
            NetworkCapabilities network,
            StorageCapabilities storage
            )
        {
            this.Network = network;
            this.Analog = analog;
            this.Storage = storage;
        }
    }
}


namespace Meadow
{
    /// <summary>
    /// Represents the storage capabilities of a device.
    /// </summary>
    public class StorageCapabilities
    {
        /// <summary>
        /// Gets a value indicating whether the device has an SD card.
        /// </summary>
        public bool HasSd { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="StorageCapabilities"/> class with the specified parameters.
        /// </summary>
        /// <param name="hasSd">Indicates whether the device has an SD card.</param>
        public StorageCapabilities(bool hasSd)
        {
            this.HasSd = hasSd;
        }
    }
}

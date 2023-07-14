namespace Meadow.Hardware
{
    /// <summary>
    /// Interface for accessing device information.
    /// </summary>
    public interface IDeviceInformation
    {
        /// <summary>
        /// Gets or sets the current device name.
        /// </summary>
        string DeviceName { get; set; }

        /// <summary>
        /// Gets the current model name.
        /// </summary>
        string Model { get; }

        /// <summary>
        /// Gets the currently executing platform.
        /// </summary>
        MeadowPlatform Platform { get; }

        /// <summary>
        /// Gets the processor type.
        /// </summary>
        string ProcessorType { get; }

        /// <summary>
        /// Gets the serial number of the device.
        /// </summary>
        string ProcessorSerialNumber { get; }

        /// <summary>
        /// Gets the unique ID of the Meadow device.
        /// </summary>
        string UniqueID { get; }

        /// <summary>
        /// Gets the coprocessor type.
        /// </summary>
        string CoprocessorType { get; }

        /// <summary>
        /// Gets the version of the firmware flashed to the coprocessor.
        /// </summary>
        string? CoprocessorOSVersion { get; }

        /// <summary>
        /// Gets the version of the firmware flashed to the microcontroller.
        /// </summary>
        string OSVersion { get; }
    }
}

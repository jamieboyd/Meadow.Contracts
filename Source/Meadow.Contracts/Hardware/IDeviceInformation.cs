namespace Meadow.Hardware
{
    /// <summary>
    /// Interface for accessing device information.
    /// </summary>
    public interface IDeviceInformation
    {
        /// <summary>
        /// The current device name.
        /// </summary>
        /// <returns>Name of the device.</returns>
        string DeviceName { get; set; }

        /// <summary>
        /// Get the current model name.
        /// </summary>
        /// <returns>Model name.</returns>
        string Model { get; }

        /// <summary>
        /// The currently executing Platform.
        /// </summary>
        MeadowPlatform Platform { get; }

        /// <summary>
        /// Get the processor type.
        /// </summary>
        /// <returns>Processor type.</returns>
        string ProcessorType { get; }

        /// <summary>
        /// Get the serial number of the device.
        /// </summary>
        /// <returns>Serial number of the device.</returns>
        string ProcessorSerialNumber { get; }

        /// <summary>
        /// Gets the unique ID of the Meadow device.
        /// </summary>
        string UniqueID { get; }

        /// <summary>
        /// Get the coprocessor type.
        /// </summary>
        /// <returns>Coprocessor type.</returns>
        string CoprocessorType { get; }

        /// <summary>
        /// Get the version of the firmware flashed to the coprocessor.
        /// </summary>
        /// <returns>Coprocessor firmware version..</returns>
        string? CoprocessorOSVersion { get; }

        /// <summary>
        /// Get the version of the firmware flashed to the microcontroller.
        /// </summary>
        string OSVersion { get; }
    }
}
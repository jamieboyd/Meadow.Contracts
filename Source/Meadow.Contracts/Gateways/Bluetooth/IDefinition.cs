namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// Represents the definition of a Bluetooth device.
    /// </summary>
    public interface IDefinition
    {
        /// <summary>
        /// Gets the name of the Bluetooth device.
        /// </summary>
        string DeviceName { get; }

        /// <summary>
        /// Gets the collection of services associated with the Bluetooth device.
        /// </summary>
        ServiceCollection Services { get; }

        /// <summary>
        /// Converts the definition to its JSON representation.
        /// </summary>
        /// <returns>The JSON representation of the definition.</returns>
        string ToJson();
    }
}

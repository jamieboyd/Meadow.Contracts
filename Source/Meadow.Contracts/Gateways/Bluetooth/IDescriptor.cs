namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// Represents a descriptor for a GATT characteristic.
    /// </summary>
    public interface IDescriptor : IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the handle of the descriptor.
        /// </summary>
        ushort Handle { get; set; }

        /// <summary>
        /// Gets the UUID of the descriptor.
        /// </summary>
        string Uuid { get; }
    }
}
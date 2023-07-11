namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// A descriptor for a GATT characteristic
    /// </summary>
    public interface IDescriptor : IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the handle of the descriptor.
        /// </summary>
        public ushort Handle { get; set; }
        /// <summary>
        /// Gets the UUID of the descriptor
        /// </summary>
        public string Uuid { get; }
    }
}

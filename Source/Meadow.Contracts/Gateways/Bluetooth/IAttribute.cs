namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// Represents a Bluetooth attribute.
    /// </summary>
    public interface IAttribute
    {
        /// <summary>
        /// Handles the write operation for the attribute with the specified data.
        /// </summary>
        /// <param name="data">The data to be written.</param>
        void HandleDataWrite(byte[] data);

        /// <summary>
        /// Gets or sets the handle of the attribute's definition.
        /// </summary>
        ushort DefinitionHandle { get; set; }

        /// <summary>
        /// Gets or sets the handle of the attribute's value.
        /// </summary>
        ushort ValueHandle { get; set; }
    }
}

namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// Represents a service in Bluetooth GATT.
    /// </summary>
    public interface IService : IJsonSerializable
    {
        /// <summary>
        /// Gets or sets the handle of the service.
        /// </summary>
        ushort Handle { get; set; }

        /// <summary>
        /// Gets the name of the service.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets the UUID of the service.
        /// </summary>
        ushort Uuid { get; }

        /// <summary>
        /// Gets the collection of characteristics associated with the service.
        /// </summary>
        CharacteristicCollection Characteristics { get; }
    }
}
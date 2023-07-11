namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// Specifies the properties of a Bluetooth characteristic.
    /// </summary>
    public enum CharacteristicProperty : byte
    {
        /// <summary>
        /// The characteristic supports the broadcast property.
        /// </summary>
        Broadcast = 1 << 0,
        /// <summary>
        /// The characteristic supports the read property.
        /// </summary>
        Read = 1 << 1,
        /// <summary>
        /// The characteristic supports the write without response property.
        /// </summary>
        WriteNoResponse = 1 << 2,
        /// <summary>
        /// The characteristic supports the write property.
        /// </summary>
        Write = 1 << 3,
        /// <summary>
        /// The characteristic supports the notify property.
        /// </summary>
        Notify = 1 << 4,
        /// <summary>
        /// The characteristic supports the indicate property.
        /// </summary>
        Indicate = 1 << 5,
        /// <summary>
        /// The characteristic supports the signed write property.
        /// </summary>
        SignedWrite = 1 << 6,
        /// <summary>
        /// The characteristic supports the extended properties property.
        /// </summary>
        ExtendedProp = 1 << 7
    }
}

namespace Meadow.Hardware
{
    /// <summary>
    /// Interface for a device/peripheral that communicates over I2C
    /// </summary>
    public interface II2cPeripheral
    {
        /// <summary>
        /// The default I2C address for the peripheral
        /// </summary>
        byte I2cDefaultAddress { get; }
    }
}
namespace Meadow.Hardware
{
    /// <summary>
    /// I2C communications abstraction
    /// </summary>
    public interface II2cCommunications : IByteCommunications
    {
        /// <summary>
        /// The I2C address of the peripheral
        /// </summary>
        byte Address { get; }

        /// <summary>
        /// The I2C bus
        /// </summary>
        II2cBus Bus { get; }
    }
}
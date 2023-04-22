namespace Meadow.Hardware
{
    public interface II2cPeripheral : IByteCommunications
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

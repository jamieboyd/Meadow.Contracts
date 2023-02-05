namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices that expose an `II2cBus`.
    /// </summary>
    public interface II2cController
    {
        /// <summary>
        /// The default I2C Bus speed, in Hz, used when speed parameters are not provided
        /// </summary>
        public static I2cBusSpeed DefaultI2cBusSpeed = I2cBusSpeed.Standard;

        /// <summary>
        /// Creates an I2C bus instance for the default pins and the requested bus speed
        /// </summary>
        /// <param name="busSpeed">The bus speed</param>
        /// <param name="busNumber">The bus number</param>
        /// <returns>An instance of an I2cBus</returns>
        II2cBus CreateI2cBus(
            int busNumber,
            I2cBusSpeed busSpeed = I2cBusSpeed.Standard
        );

        /// <summary>
        /// Creates an I2C bus instance for the requested pins and bus speed
        /// </summary>
        /// <param name="pins">An array of two pins holding the I2C clock and data pins</param>
        /// <param name="busSpeed">The bus speed</param>
        /// <returns>An instance of an I2cBus</returns>
        II2cBus CreateI2cBus(
            IPin[] pins,
            I2cBusSpeed busSpeed
        );

        /// <summary>
        /// Creates an I2C bus instance for the requested pins and bus speed
        /// </summary>
        /// <param name="clock">The I2C clock pin</param>
        /// <param name="data">The I2C data pin</param>
        /// <param name="busSpeed">The bus speed</param>
        /// <returns>An instance of an I2cBus</returns>
        II2cBus CreateI2cBus(
            IPin clock,
            IPin data,
            I2cBusSpeed busSpeed
        );
    }
}
using Meadow.Units;

namespace Meadow.Hardware
{
    /// <summary>
    /// Interface for a device/peripheral that communicates over SPI
    /// </summary>
    public interface ISpiPeripheral
    {
        /// <summary>
        /// Default SPI bus mode
        /// </summary>
        SpiClockConfiguration.Mode DefaultSpiBusMode { get; }

        /// <summary>
        /// Current SPI bus mode
        /// </summary>
        SpiClockConfiguration.Mode SpiBusMode { get; set; }

        /// <summary>
        /// Default SPI bus speed for the peripheral
        /// </summary>
        Frequency DefaultSpiBusSpeed { get; }

        /// <summary>
        /// Current SPI bus speed
        /// </summary>
        Frequency SpiBusSpeed { get; set; }
    }
}
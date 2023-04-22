using Meadow.Units;

namespace Meadow.Hardware
{
    /// <summary>
    /// Interface for a device that communicates over SPI
    /// </summary>
    public interface ISpiDevice
    {
        /// <summary>
        /// SPI bus mode
        /// </summary>
        SpiClockConfiguration.Mode DefaultSpiBusMode { get; }

        /// <summary>
        /// SPI bus speed
        /// </summary>
        Frequency DefaultSpiBusSpeed { get; }

        /// <summary>
        /// SPI bus mode
        /// </summary>
        SpiClockConfiguration.Mode SpiBusMode { get; set; }

        /// <summary>
        /// SPI bus speed
        /// </summary>
        Frequency SpiBusSpeed { get; set; }
    }
}
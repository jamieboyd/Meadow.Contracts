using Meadow.Units;

namespace Meadow.Hardware
{
    /// <summary>
    /// SPI peripheral abstraction
    /// </summary>
    public interface ISpiPeripheral : IByteCommunications
    {
        /// <summary>
        /// Chip select port
        /// </summary>
        IDigitalOutputPort ChipSelect { get; }

        /// <summary>
        /// SPI bus
        /// </summary>
        ISpiBus Bus { get; }

        /// <summary>
        /// SPI bus speed
        /// </summary>
        Frequency BusSpeed { get; set; }

        /// <summary>
        /// SPI bus mode
        /// </summary>
        SpiClockConfiguration.Mode BusMode { get; set; }
    }
}
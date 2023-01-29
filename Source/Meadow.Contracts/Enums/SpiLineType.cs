using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Description of a SPI line function
    /// </summary>
    [Flags]
    public enum SpiLineType
    {
        /// <summary>
        /// Not a SPI function
        /// </summary>
        None = 0,
        /// <summary>
        /// A SPI Controller-out Peripheral-in line
        /// </summary>
        COPI = 1 << 0,
        /// <summary>
        /// A SPI Controller-in Peripheral-out line
        /// </summary>
        CIPO = 1 << 1,
        /// <summary>
        /// A SPI Clock line
        /// </summary>
        Clock = 1 << 2,
        /// <summary>
        /// A SPI Chip Select line
        /// </summary>
        ChipSelect = 1 << 3,

        /// <summary>
        /// Backward compatible alias for COPI
        /// </summary>
        MOSI = COPI,
        /// <summary>
        /// Backward compatible alias for CIPO
        /// </summary>
        MISO = CIPO

    }
}

using Meadow.Hardware;

namespace Meadow
{
    /// <summary>
    /// Interface representing an I/O device that combines functionality
    /// for digital input/output, SPI, and I2C controllers.
    /// </summary>
    public interface IIoDevice :
        IDigitalInputOutputController,
        ISpiController,
        II2cController
    {
    }
}
using Meadow.Hardware;

namespace Meadow
{
    public interface IIoDevice :
        IDigitalInputOutputController,
        ISpiController,
        II2cController
    {
    }
}

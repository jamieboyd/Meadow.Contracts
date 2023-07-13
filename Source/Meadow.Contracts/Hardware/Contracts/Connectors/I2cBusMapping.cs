namespace Meadow;

using Meadow.Hardware;

public sealed class I2cBusMapping
{
    public I2cBusMapping(II2cController controller, int busNumber)
    {
        Controller = controller;
        BusNumber = busNumber;
    }

    public II2cController Controller { get; }
    public int BusNumber { get; }

}

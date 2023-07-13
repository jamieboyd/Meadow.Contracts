namespace Meadow;

using Meadow.Hardware;

/// <summary>
/// Represents a mapping of a specific I2C bus on a controller
/// </summary>
public sealed class I2cBusMapping
{
    /// <summary>
    /// Creates an I2cBusMapping
    /// </summary>
    /// <param name="controller">The II2cController</param>
    /// <param name="busNumber">The specific bus number on the controller</param>
    public I2cBusMapping(II2cController controller, int busNumber)
    {
        Controller = controller;
        BusNumber = busNumber;
    }

    /// <summary>
    /// The mapped II2cController
    /// </summary>
    public II2cController Controller { get; }
    /// <summary>
    /// The mapped bus number
    /// </summary>
    public int BusNumber { get; }

}

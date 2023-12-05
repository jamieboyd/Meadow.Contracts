namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Abstraction for a sensor that polls its value
/// </summary>
public interface IPollingSensor : ISamplingSensor
{
    /// <summary>
    /// Gets or sets the monitor responsible for reading the sensor
    /// </summary>
    public ISensorMonitor? SensorMonitor { get; set; }
}
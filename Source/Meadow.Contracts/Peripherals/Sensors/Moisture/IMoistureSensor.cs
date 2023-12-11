namespace Meadow.Peripherals.Sensors.Moisture;

/// <summary>
/// Represents a moisture sensor that measures the moisture level.
/// </summary>
public interface IMoistureSensor : ISamplingSensor<double>
{
    /// <summary>
    /// Gets the last value read from the moisture sensor.
    /// </summary>
    double? Moisture { get; }
}
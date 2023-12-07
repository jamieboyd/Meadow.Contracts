using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Atmospheric;

/// <summary>
/// Humidity sensor interface requirements.
/// </summary>
public interface IHumiditySensor : ISamplingSensor<RelativeHumidity>
{
    /// <summary>
    /// Last value read from the humidity sensor.
    /// </summary>
    RelativeHumidity? Humidity { get; }
}
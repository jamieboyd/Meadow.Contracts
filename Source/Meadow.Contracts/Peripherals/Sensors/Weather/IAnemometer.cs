using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Weather;

/// <summary>
/// Represents an anemometer sensor that measures the speed of the wind.
/// </summary>
public interface IAnemometer : ISamplingSensor<Speed>
{
    /// <summary>
    /// Gets the last recorded wind speed.
    /// </summary>
    Speed? WindSpeed { get; }
}

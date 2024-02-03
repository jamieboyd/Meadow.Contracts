using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Weather;

/// <summary>
/// Represents a rain gauge to measure accumulated rainfall depth.
/// </summary>
public interface IRainGauge : ISamplingSensor<Speed>
{
    /// <summary>
    /// Gets the total accumulated rainfall depth.
    /// </summary>
    Length RainDepth { get; }
}
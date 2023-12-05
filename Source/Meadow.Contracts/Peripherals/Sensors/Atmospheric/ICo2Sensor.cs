using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Atmospheric;

/// <summary>
/// CO2 sensor interface requirements.
/// </summary>
public interface ICo2Sensor : ISamplingSensor<Concentration>
{
    /// <summary>
    /// Last value read from the CO2 sensor.
    /// </summary>
    Concentration? Co2 { get; }
}
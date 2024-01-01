using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// CO2 Concentration interface requirements.
/// </summary>
public interface ICO2ConcentrationSensor : ISamplingSensor<Concentration>
{
    /// <summary>
    /// Last value read from the CO2 Concentration sensor.
    /// </summary>
    Concentration? CO2Concentration { get; }
}
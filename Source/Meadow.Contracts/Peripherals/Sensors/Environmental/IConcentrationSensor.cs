using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// Concentration interface requirements.
/// </summary>
public interface IConcentrationSensor : ISamplingSensor<Concentration>
{
    /// <summary>
    /// Last value read from the Concentration sensor.
    /// </summary>
    Concentration? Concentration { get; }
}
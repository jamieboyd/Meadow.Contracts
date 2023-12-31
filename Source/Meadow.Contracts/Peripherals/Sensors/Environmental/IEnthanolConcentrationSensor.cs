using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// Ethanol Concentration interface requirements.
/// </summary>
public interface IEthanolConcentrationSensor : ISamplingSensor<Concentration>
{
    /// <summary>
    /// Last value read from the Ethanol Concentration sensor.
    /// </summary>
    Concentration? EthanolConcentration { get; }
}
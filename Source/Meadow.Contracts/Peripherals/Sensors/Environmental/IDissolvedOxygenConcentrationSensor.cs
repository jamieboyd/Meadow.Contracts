using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// Dissolved oxygen concetration interface requirements
/// </summary>
public interface IDissolvedOxygenConcentrationSensor : ISamplingSensor<ConcentrationInWater>
{
    /// <summary>
    /// Last value read from the dissolved xxygen concentration sensor
    /// </summary>
    ConcentrationInWater? Concentration { get; }
}
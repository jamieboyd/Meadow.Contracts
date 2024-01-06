using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// Volotile Organic Compounds (VOC) Concentration interface requirements.
/// </summary>
public interface IVOCConcentrationSensor : ISamplingSensor<Concentration>
{
    /// <summary>
    /// Last value read from the VOC Concentration sensor.
    /// </summary>
    Concentration? VOCConcentration { get; }
}
using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Atmospheric;

/// <summary>
/// Volatile Organic Compound (VOC) sensor interface requirements.
/// </summary>
public interface IVocSensor : ISamplingSensor<Concentration>
{
    /// <summary>
    /// Last value read from the VOC sensor.
    /// </summary>
    Concentration? Voc { get; }
}
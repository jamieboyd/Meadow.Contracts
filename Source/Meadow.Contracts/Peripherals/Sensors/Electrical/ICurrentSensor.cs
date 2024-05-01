using Meadow.Units;

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Electrical Current sensor interface requirements.
/// </summary>
public interface ICurrentSensor : ISamplingSensor<Current>
{
    /// <summary>
    /// Last value read from the Current sensor.
    /// </summary>
    public Current? Current { get; }
}

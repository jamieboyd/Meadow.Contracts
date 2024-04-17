using Meadow.Units;

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Electrical Power sensor interface requirements.
/// </summary>
public interface IPowerSensor : ISamplingSensor<Power>
{
    /// <summary>
    /// Last value read from the Power sensor.
    /// </summary>
    public Power? Power { get; }
}

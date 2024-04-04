using Meadow.Units;

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Voltage sensor interface requirements.
/// </summary>
public interface IVoltageSensor : ISamplingSensor<Voltage>
{
    /// <summary>
    /// Last value read from the Voltage sensor.
    /// </summary>
    public Voltage? Voltage { get; }
}

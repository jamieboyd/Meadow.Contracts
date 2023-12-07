using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Atmospheric;

/// <summary>
/// Pressure sensor interface requirements.
/// </summary>
public interface IBarometricPressureSensor : ISamplingSensor<Pressure>
{
    /// <summary>
    /// Last value read from the Pressure sensor.
    /// </summary>
    Pressure? Pressure { get; }
}
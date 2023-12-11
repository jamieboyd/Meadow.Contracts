namespace Meadow.Peripherals.Sensors.Mass;

/// <summary>
/// Mass sensor interface requirements.
/// </summary>
public interface IMassSensor : ISamplingSensor<Units.Mass>
{
    /// <summary>
    /// Last value read from the sensor.
    /// </summary>
    Units.Mass? Mass { get; }
}
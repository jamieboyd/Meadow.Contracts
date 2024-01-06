namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// Dissolved xxygen saturation interface requirements
/// </summary>
public interface IDissolvedOxygenSaturationSensor : ISamplingSensor<double>
{
    /// <summary>
    /// Last value read from the dissolved oxygen saturation sensor
    /// </summary>
    double? Saturation { get; }
}
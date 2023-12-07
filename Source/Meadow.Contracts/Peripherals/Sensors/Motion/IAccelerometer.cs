using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Motion;

/// <summary>
/// Represents a generic accelerometer sensor.
/// </summary>
public interface IAccelerometer : ISamplingSensor<Acceleration3D>
{
    /// <summary>
    /// Last value read from the sensor.
    /// </summary>
    Acceleration3D? Acceleration3D { get; }
}
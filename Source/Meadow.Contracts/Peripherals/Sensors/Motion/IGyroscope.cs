using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Motion;

/// <summary>
/// Represents a generic gyroscopic sensor that measures angular velocity.
/// </summary>
public interface IGyroscope : ISamplingSensor<AngularVelocity3D>
{
    /// <summary>
    /// Last value read from the sensor.
    /// </summary>
    AngularVelocity3D? AngularVelocity3D { get; }
}
using System;

namespace Meadow.Peripherals.Motors;

/// <summary>
/// Interface describing DC motors.
/// </summary>
public interface IDCMotor
{
    /// <summary>
    /// The speed of the motor from -1 to 1.
    /// </summary>
    /// <remarks>Deprecated, please use `Power`.</remarks>
    [Obsolete("Deprecated, please use `Power`.")]
    float Speed { get => Power; set => Power = value; }

    /// <summary>
    /// The power applied to the motor, as a percentage between
    /// `-1.0` and `1.0`.
    /// </summary>
    float Power { get; set; }

    /// <summary>
    /// When true, the wheels spin "freely"
    /// </summary>
    bool IsNeutral { get; set; }
}

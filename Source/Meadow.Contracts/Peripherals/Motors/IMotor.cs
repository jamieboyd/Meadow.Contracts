using System;
using System.Threading;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Motors;

/// <summary>
/// Represents an interface for controlling a motor.
/// </summary>
public interface IMotor
{
    /// <summary>
    /// Gets the direction the motor is currently moving (or last moved) in
    /// </summary>
    public RotationDirection Direction { get; }

    /// <summary>
    /// Run the motor for the specified time in the specified direction.
    /// </summary>
    /// <param name="direction"></param>
    /// <param name="runTime"></param>
    /// <param name="power">The percent power the motor should run at</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// This method will not return until the time has elapsed or the <see cref="CancellationToken"/> is cancelled.
    /// The power is a percentage from 0 to 100.
    /// </remarks>
    Task RunFor(TimeSpan runTime, RotationDirection direction, float power, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Run the motor in the specified direction until <see cref="Stop"/> is called or the <see cref="CancellationToken"/> is cancelled.
    /// </summary>
    /// <param name="direction"></param>
    /// <param name="power">The percent power the motor should run at</param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// This method will not return until <see cref="Stop"/> is called or the <see cref="CancellationToken"/> is cancelled.
    /// The power is a percentage from 0 to 100.
    /// </remarks>
    Task Run(RotationDirection direction, float power, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Stop the motor
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <remarks>
    /// This method will stop a running motor, even if <see cref="RunFor"/> started it. If the motor is not running, this method will do nothing.
    /// </remarks>
    Task Stop(CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Gets if the motor is currently moving.
    /// </summary>
    /// <remarks>
    /// This property will return true if the motor is currently executing a run command. this may or may not account for motor ramp up or down, depending on the motor/drive capabilities.
    /// This property may also return true if external forces are causing the motor to rotate, provided the motor/drive is capable of determining the condition.
    /// </remarks>
    bool IsMoving { get; }
}

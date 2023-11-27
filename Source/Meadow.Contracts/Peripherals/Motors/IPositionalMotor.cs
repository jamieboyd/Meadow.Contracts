using Meadow.Units;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Motors;

/// <summary>
/// Represents an interface for controlling a positional motor.
/// </summary>
public interface IPositionalMotor : IMotor
{
    /// <summary>
    /// Go to the specified position at the specified power.
    /// </summary>
    /// <param name="position">The desired position for the motor</param>
    /// <param name="velocity">The speed to use to get to the desired <paramref name="position"/></param>
    /// <param name="cancellationToken"></param>
    Task GoTo(Angle position, AngularVelocity velocity, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Run the motor in the specified direction at the specified power.
    /// </summary>
    /// <param name="direction"></param>
    /// <param name="velocity"></param>
    /// <param name="cancellationToken"></param>
    Task Run(RotationDirection direction, AngularVelocity velocity, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Run the motor in the specified direction at the specified power for the specified time.
    /// </summary>
    /// <param name="direction"></param>
    /// <param name="runTime"></param>
    /// <param name="velocity"></param>
    /// <param name="cancellationToken"></param>
    Task RunFor(RotationDirection direction, TimeSpan runTime, AngularVelocity velocity, CancellationToken cancellationToken = default(CancellationToken));

    /// <summary>
    /// Reset the current position to 0
    /// </summary>
    /// <param name="cancellationToken"></param>
    Task ResetPosition(CancellationToken cancellationToken = default(CancellationToken));
}

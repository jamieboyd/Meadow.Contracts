using Meadow.Units;
using System.Threading;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Motors;


/// <summary>
/// Represents an interface for controlling a stepper motor.
/// </summary>
public interface IStepperMotor : IPositionalMotor
{
    /// <summary>
    /// Rotates the stepper motor by the specified number of steps in the specified direction with the given frequency.
    /// </summary>
    /// <param name="steps">The number of steps to rotate the motor.</param>
    /// <param name="direction">The direction in which to rotate the motor.</param>
    /// <param name="rate">The frequency of the steps at which to rotate the motor.</param>
    /// <param name="cancellationToken">A token to cancel the operation.</param>
    Task Rotate(int steps, RotationDirection direction, Frequency rate, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets the number of steps required for the stepper motor to complete one full revolution.
    /// </summary>
    int StepsPerRevolution { get; }
}

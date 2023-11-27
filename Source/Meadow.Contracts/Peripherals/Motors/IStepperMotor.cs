using Meadow.Units;

namespace Meadow.Peripherals.Motors;


/// <summary>
/// Represents an interface for controlling a stepper motor.
/// </summary>
public interface IStepperMotor
{
    /// <summary>
    /// Gets the number of steps per revolution of the stepper motor.
    /// </summary>
    int StepsPerRevolution { get; }

    /// <summary>
    /// Moves the stepper motor a specified number of steps in a given direction at a specified rate.
    /// </summary>
    /// <param name="steps">The number of steps to move.</param>
    /// <param name="direction">The direction of rotation.</param>
    /// <param name="rate">The rotation rate in steps per second.</param>
    void Step(int steps, RotationDirection direction, Frequency rate);

    /// <summary>
    /// Rotates the stepper motor by a specified angle in a given direction at a specified rate.
    /// </summary>
    /// <param name="angle">The angle to rotate.</param>
    /// <param name="direction">The direction of rotation.</param>
    /// <param name="rate">The rotation rate in steps per second.</param>
    void Rotate(Angle angle, RotationDirection direction, Frequency rate)
    {
        Step((int)(StepsPerRevolution / 360f * angle.Degrees), direction, rate);
    }

    /// <summary>
    /// Rotates the stepper motor by a specified number of degrees in a given direction at a specified rate.
    /// </summary>
    /// <param name="degrees">The number of degrees to rotate.</param>
    /// <param name="direction">The direction of rotation.</param>
    /// <param name="rate">The rotation rate in steps per second.</param>
    void Rotate(float degrees, RotationDirection direction, Frequency rate)
    {
        Step((int)(StepsPerRevolution / 360f * degrees), direction, rate);
    }
}

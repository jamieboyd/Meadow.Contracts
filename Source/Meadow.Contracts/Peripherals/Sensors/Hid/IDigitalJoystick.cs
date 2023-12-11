using System;

namespace Meadow.Peripherals.Sensors.Hid;

/// <summary>
/// Interface describing digital joysticks and d-pads.
/// </summary>
public interface IDigitalJoystick
{
    /// <summary>
    /// Gets the position of the joystick.
    /// </summary>
    DigitalJoystickPosition? Position { get; }

    /// <summary>
    /// Raised when a new reading has been made. 
    /// </summary>
    event EventHandler<ChangeResult<DigitalJoystickPosition>> Updated;
}
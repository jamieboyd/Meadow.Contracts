namespace Meadow.Peripherals.Sensors.Hid;

/// <summary>
/// Represents 8-way digital joystick positions
/// </summary>
public enum DigitalJoystickPosition
{
    /// <summary>
    /// Center / neutral position
    /// </summary>
    Center,
    /// <summary>
    /// Up or top position with no horizontal movement
    /// </summary>
    Up,
    /// <summary>
    /// Down or button position with no horizontal movement
    /// </summary>
    Down,
    /// <summary>
    /// Left position with no vertical movement
    /// </summary>
    Left,
    /// <summary>
    /// Right position with no vertical movement
    /// </summary>
    Right,
    /// <summary>
    /// Upper right position
    /// </summary>
    UpRight,
    /// <summary>
    /// Upper left position
    /// </summary>
    UpLeft,
    /// <summary>
    /// Lower right position
    /// </summary>
    DownRight,
    /// <summary>
    /// Lower left position
    /// </summary>
    DownLeft,
}
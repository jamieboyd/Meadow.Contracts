namespace Meadow.Peripherals.Sensors.Hid
{
    /// <summary>
    /// Represents a position that an analog joystick can having, including both
    /// the `Horizontal` and `Vertical` components.
    /// </summary>
    public struct AnalogJoystickPosition
    {
        /// <summary>
        /// Current horizonal position of joystick
        /// </summary>
        public float? Horizontal { get; set; }

        /// <summary>
        /// Current vertical position of joystick
        /// </summary>
        public float? Vertical { get; set; }

        /// <summary>
        /// Represents the position of a 2-axis joystick
        /// </summary>
        /// <param name="horizontal">horizonal position</param>
        /// <param name="vertical">vertical position</param>
        public AnalogJoystickPosition(float? horizontal, float? vertical) 
        {
            Horizontal = horizontal;
            Vertical = vertical;
        }

        /// <summary>
        /// Create a new JoystickPosition instance
        /// </summary>
        /// <param name="position">Reference position to copy values from</param>
        /// <returns></returns>
        public static AnalogJoystickPosition From(AnalogJoystickPosition position) 
        {
            return new AnalogJoystickPosition(position.Horizontal, position.Vertical);
        }
    }
}
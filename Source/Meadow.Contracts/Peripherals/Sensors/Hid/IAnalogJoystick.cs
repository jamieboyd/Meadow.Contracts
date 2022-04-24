using System;

namespace Meadow.Peripherals.Sensors.Hid
{
    /// <summary>
    /// Interface describing 2-axis analog joysticks.
    /// </summary>
    public interface IAnalogJoystick
    {
        /// <summary>
        /// Is the horizontal / x-axis inverted 
        /// </summary>
        public bool IsHorizontalInverted { get; protected set; }

        /// <summary>
        /// Is the horizontal / x-axis inverted 
        /// </summary>
        public bool IsVerticalInverted { get; protected set; }

        /// <summary>
        /// Current position of
        /// </summary>
        public AnalogJoystickPosition? Position { get; protected set; }

        /// <summary>
        /// Raised when a new reading has been made. 
        /// </summary>
        event EventHandler<ChangeResult<AnalogJoystickPosition>> Updated;
    }
}

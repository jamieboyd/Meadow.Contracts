using System;

namespace Meadow.Peripherals.Sensors.Hid
{
    /// <summary>
    /// Interface describing 2-axis analog joysticks
    /// </summary>
    public interface IAnalogJoystick
    {
        /// <summary>
        /// Is the horizontal / x-axis inverted 
        /// </summary>
        public bool IsHorizontalInverted { get; set; }

        /// <summary>
        /// Is the vertical / y-axis inverted 
        /// </summary>
        public bool IsVerticalInverted { get; set; }

        /// <summary>
        /// Current position of analog joystick
        /// </summary>
        public AnalogJoystickPosition? Position { get; }

        /// <summary>
        /// Raised when a new reading has been made. 
        /// </summary>
        event EventHandler<IChangeResult<AnalogJoystickPosition>> Updated;
    }
}

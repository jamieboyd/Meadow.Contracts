using System;

namespace Meadow.Peripherals.Sensors.Rotary
{
    /// <summary>
    /// Defines the event args for the RotaryTurned event.
    /// </summary>
    public struct RotaryChangeResult : IChangeResult<RotationDirection>
    {
        /// <summary>
        /// Gets or sets the rotary's direction. (Obsolete: Please use the `New` property.)
        /// </summary>
        [Obsolete("Please use the `New` property.")]
        public RotationDirection Direction
        {
            get { return New; }
        }

        /// <summary>
        /// Gets or sets the new direction of rotation.
        /// </summary>
        public RotationDirection New { get; set; }

        /// <summary>
        /// Gets or sets the previous direction of rotation.
        /// </summary>
        public RotationDirection? Old { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="RotaryChangeResult"/> struct with the specified new and old direction values.
        /// </summary>
        /// <param name="newValue">The new direction of rotation.</param>
        /// <param name="oldValue">The previous direction of rotation.</param>
        public RotaryChangeResult(RotationDirection newValue, RotationDirection? oldValue)
        {
            New = newValue;
            Old = oldValue;
        }
    }
}

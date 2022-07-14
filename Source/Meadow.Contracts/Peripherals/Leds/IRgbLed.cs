namespace Meadow.Peripherals.Leds
{
    /// <summary>
    /// Defines an RGB Light Emitting Diode (LED).
    /// </summary>
    public interface IRgbLed
    {
        /// <summary>
        /// Gets or sets a value indicating whether the LED is on.
        /// </summary>
        /// <value><c>true</c> if is on; otherwise, <c>false</c>.</value>
        bool IsOn { get; set; }

        /// <summary>
        /// Gets or sets the LED color
        /// </summary>
        RgbLedColors Color { get; }
    }
}
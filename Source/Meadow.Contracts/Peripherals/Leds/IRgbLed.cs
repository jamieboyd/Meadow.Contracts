namespace Meadow.Peripherals.Leds;

/// <summary>
/// Defines an RGB Light Emitting Diode (LED).
/// </summary>
public interface IRgbLed
{
    /// <summary>
    /// Gets or sets a value indicating whether the LED is on.
    /// </summary>
    bool IsOn { get; set; }
}
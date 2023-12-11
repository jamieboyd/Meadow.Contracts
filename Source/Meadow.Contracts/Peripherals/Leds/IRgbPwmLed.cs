namespace Meadow.Peripherals.Leds;

/// <summary>
/// Defines a Pulse-Width-Modulation (PWM) controlled RGB LED.
/// </summary>
public interface IRgbPwmLed
{
    /// <summary>
    /// Gets or sets a value indicating whether the LED is on.
    /// </summary>
    bool IsOn { get; set; }
}
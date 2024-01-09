using System;
using System.Threading.Tasks;

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

    /// <summary>
    /// Sets the current color of the LED.
    /// </summary>
    /// <param name="color">The color value</param>
    void SetColor(RgbLedColors color);

    /// <summary>
    /// Stops the current LED animation
    /// </summary>
    Task StopAnimation();

    /// <summary>
    /// Start the Blink animation which sets turns the LED on and off on an interval of 1 second (500ms on, 500ms off)
    /// </summary>
    Task StartBlink();

    /// <summary>
    /// Start the Blink animation which sets turns the LED on and off on an interval of 1 second (500ms on, 500ms off)
    /// </summary>
    /// <param name="color">The LED color</param>
    Task StartBlink(RgbLedColors color);

    /// <summary>
    /// Start the Blink animation which sets turns the LED on and off with the specified durations and current color
    /// </summary>
    /// <param name="onDuration">The duration the LED stays on</param>
    /// <param name="offDuration">The duration the LED stays off</param>
    Task StartBlink(TimeSpan onDuration, TimeSpan offDuration);

    /// <summary>
    /// Start the Blink animation which sets turns the LED on and off with the specified durations and color
    /// </summary>
    /// <param name="color">The LED color</param>
    /// <param name="onDuration">The duration the LED stays on</param>
    /// <param name="offDuration">The duration the LED stays off</param>
    Task StartBlink(RgbLedColors color, TimeSpan onDuration, TimeSpan offDuration);
}
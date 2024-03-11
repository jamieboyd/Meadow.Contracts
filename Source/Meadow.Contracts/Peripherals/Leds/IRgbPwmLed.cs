using System;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Leds;

/// <summary>
/// Defines a Pulse-Width-Modulation (PWM) controlled RGB LED.
/// </summary>
public interface IRgbPwmLed : IPwmLed, IRgbLed
{
    /// <summary>
    /// Sets the current color of the LED
    /// </summary>
    /// <param name="color">The LED color</param>
    /// <param name="brightness">Valid values are from 0 to 1, inclusive</param>
    void SetColor(Color color, float brightness = 1);

    /// <summary>
    /// Start the Blink animation which sets the brightness of the LED alternating
    /// between a low and high brightness on an interval of 1 second (500ms on, 500ms off)
    /// </summary>
    /// <param name="color">The LED color</param>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartBlink(Color color, float highBrightness = 1f, float lowBrightness = 0f);

    /// <summary>
    /// Start the Blink animation which sets the brightness of the LED alternating 
    /// between a low and high brightness setting, using the durations provided
    /// </summary>
    /// <param name="color">The LED color</param>
    /// <param name="onDuration">The duration the LED stays on</param>
    /// <param name="offDuration">The duration the LED stays off</param>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartBlink(Color color, TimeSpan onDuration, TimeSpan offDuration, float highBrightness = 1f, float lowBrightness = 0f);

    /// <summary>
    /// Start the Pulse animation which gradually alternates the brightness of 
    /// the LED between a low and high brightness setting with a cycle time of 600ms
    /// </summary>
    /// <param name="color">The LED color</param>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartPulse(Color color, float highBrightness = 1, float lowBrightness = 0.15F);

    /// <summary>
    /// Start the Pulse animation which gradually alternates the brightness of the 
    /// LED between a low and high brightness setting, using the duration provided
    /// and especified color
    /// </summary>
    /// <param name="color">The LED color</param>
    /// <param name="pulseDuration">The pulse animation duration</param>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartPulse(Color color, TimeSpan pulseDuration, float highBrightness = 1, float lowBrightness = 0.15F);
}
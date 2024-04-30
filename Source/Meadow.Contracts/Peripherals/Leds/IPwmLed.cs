using System;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Leds;

/// <summary>
/// Defines a Light Emitting Diode (LED) controlled by a pulse-width-modulation
/// (PWM) signal to limit current.
/// </summary>
public interface IPwmLed : ILed
{
    /// <summary>
    /// Gets the brightness of the LED, controlled by a PWM signal
    /// </summary>
    float Brightness { get; }

    /// <summary>
    /// Start a Blink animation which sets the brightness of the LED alternating between a low and high brightness setting.
    /// </summary>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartBlink(float highBrightness, float lowBrightness);

    /// <summary>
    /// Start the Blink animation which sets the brightness of the LED alternating between a low and high brightness setting, using the durations provided.
    /// </summary>
    /// <param name="highBrightnessDuration">The duration the LED stays in high brightness</param>
    /// <param name="lowBrightnessDuration">The duration the LED stays in low brightness</param>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartBlink(TimeSpan highBrightnessDuration, TimeSpan lowBrightnessDuration, float highBrightness = 1f, float lowBrightness = 0f);

    /// <summary>
    /// Start the Pulse animation which gradually alternates the brightness of the LED between a low and high brightness setting.
    /// </summary>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartPulse(float highBrightness = 1, float lowBrightness = 0.15F);

    /// <summary>
    /// Start the Pulse animation which gradually alternates the brightness of the LED between a low and high brightness setting, using the durations provided.
    /// </summary>
    /// <param name="pulseDuration">The pulse animation duration</param>
    /// <param name="highBrightness">The maximum brightness of the animation</param>
    /// <param name="lowBrightness">The minimum brightness of the animation</param>
    Task StartPulse(TimeSpan pulseDuration, float highBrightness = 1, float lowBrightness = 0.15F);

    /// <summary>
    /// Set the LED brightness
    /// </summary>
    /// <param name="brightness">Valid values are from 0 to 1, inclusive</param>
    public void SetBrightness(float brightness);
}
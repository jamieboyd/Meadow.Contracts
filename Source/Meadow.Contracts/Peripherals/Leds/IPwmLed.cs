using System;

namespace Meadow.Peripherals.Leds
{
    /// <summary>
    /// Defines a Light Emitting Diode (LED) controlled by a pulse-width-modulation
    /// (PWM) signal to limit current.
    /// </summary>
    public interface IPwmLed
    {
        /// <summary>
        /// Gets or sets a value indicating whether the LED is on.
        /// </summary>
        /// <value><c>true</c> if is on; otherwise, <c>false</c>.</value>
        bool IsOn { get; set; }

        /// <summary>
        /// Gets the brightness of the LED, controlled by a PWM signal
        /// </summary>
        public float Brightness { get; set; }

        /// <summary>
        /// Start the Blink animation which sets the brightness of the LED alternating between a low and high brightness setting, using the durations provided.
        /// </summary>
        public void StartBlink(TimeSpan onDuration, TimeSpan offDuration, float highBrightness = 1f, float lowBrightness = 0f);

        /// <summary>
        /// Start the Pulse animation which gradually alternates the brightness of the LED between a low and high brightness setting, using the durations provided.
        /// </summary>
        public void StartPulse(TimeSpan pulseDuration, float highBrightness, float lowBrightness = 0.15F);

        /// <summary>
        /// Stops any running animations.
        /// </summary>
        public void Stop();
    }
}
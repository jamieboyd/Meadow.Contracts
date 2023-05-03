using System;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Leds
{
    /// <summary>
    /// Defines a simple Light Emitting Diode (LED).
    /// </summary>
    public interface ILed
    {
        /// <summary>
        /// Gets or sets a value indicating whether the LED is on.
        /// </summary>
        /// <value><c>true</c> if is on; otherwise, <c>false</c>.</value>
        bool IsOn { get; set; }

        /// <summary>
        /// Blink animation that turns the LED on (500ms) and off (500ms)
        /// </summary>
        Task StartBlink();

        /// <summary>
        /// Blink animation that turns the LED on and off based on the OnDuration and offDuration values in ms
        /// </summary>
        /// <param name="onDuration"></param>
        /// <param name="offDuration"></param>
        Task StartBlink(TimeSpan onDuration, TimeSpan offDuration);

        /// <summary>
        /// Stops blink animation.
        /// </summary>
        Task StopAnimation();
    }
}
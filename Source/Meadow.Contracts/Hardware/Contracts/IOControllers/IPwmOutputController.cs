using Meadow.Units;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices that expose `IPwmPort(s)`.
    /// </summary>
    public interface IPwmOutputController : IPinController
    {
        /// <summary>
        /// The default PWM frequency.
        /// </summary>
        public const float DefaultPwmFrequency = 100f;

        /// <summary>
        /// The default PWM duty cycle.
        /// </summary>
        public const float DefaultPwmDutyCycle = 0.5f;

        /// <summary>
        /// Creates an IPwmPort on the specified pin.
        /// </summary>
        /// <param name="pin">The pin on which to create the PWM port.</param>
        /// <param name="frequency">The desired frequency of the PWM signal.</param>
        /// <param name="dutyCycle">The desired duty cycle of the PWM signal. Defaults to <see cref="DefaultPwmDutyCycle"/>.</param>
        /// <param name="invert">Specifies whether the PWM signal should be inverted. Defaults to false.</param>
        /// <returns>The created PWM port.</returns>
        IPwmPort CreatePwmPort(
            IPin pin,
            Frequency frequency,
            float dutyCycle = DefaultPwmDutyCycle,
            bool invert = false
        );
    }
}

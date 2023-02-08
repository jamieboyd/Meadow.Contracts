using Meadow.Units;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices that expose `IPwmPort(s)`.
    /// </summary>
    public interface IPwmOutputController : IPinController
    {
        public const float DefaultPwmFrequency = 100f;
        public const float DefaultPwmDutyCycle = 0.5f;

        IPwmPort CreatePwmPort(
            IPin pin,
            Frequency frequency,
            float dutyCycle = DefaultPwmDutyCycle,
            bool invert = false
        );
    }
}

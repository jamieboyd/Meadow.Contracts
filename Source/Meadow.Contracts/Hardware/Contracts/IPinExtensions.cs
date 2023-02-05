using Meadow.Units;
using System;
using System.Linq;

namespace Meadow.Hardware
{
    public static class IPinExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TChannel"></typeparam>
        /// <param name="pin"></param>
        /// <example>pin.Supports&lt;IIPwmChannelInfo&gt;();</example>
        /// <returns></returns>
        public static bool Supports<TChannel>(this IPin pin)
            where TChannel : IChannelInfo
        {
            var chan = pin.SupportedChannels.OfType<TChannel>().FirstOrDefault();
            return chan != null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TChannel"></typeparam>
        /// <param name="pin"></param>
        /// <param name="where"></param>
        /// <example>pin.Supports&lt;IDigitalChannelInfo&gt;(c =&gt; c.OutputCapable);</example>
        /// <returns></returns>
        public static bool Supports<TChannel>(this IPin pin, Func<TChannel, bool> where)
            where TChannel : IChannelInfo
        {
            var chan = pin.SupportedChannels.OfType<TChannel>().Where(where).FirstOrDefault();
            return chan != null;
        }

        public static IDigitalOutputPort CreateDigitalOutputPort(this IPin pin, bool initialState = false)
        {
            if (pin.Controller is IDigitalOutputController controller)
            {
                return controller.CreateDigitalOutputPort(pin, initialState);
            }

            throw new ArgumentException("Pin is not digital output capable");
        }

        public static IDigitalInputPort CreateDigitalInputPort(this IPin pin, InterruptMode interruptMode, ResistorMode resistorMode, TimeSpan debounceDuration, TimeSpan glitchDuration)
        {
            if (pin.Controller is IDigitalInputController controller)
            {
                return controller.CreateDigitalInputPort(pin, interruptMode, resistorMode, debounceDuration, glitchDuration);
            }

            throw new ArgumentException("Pin is not digital input capable");
        }

        public static IDigitalInputPort CreateDigitalInputPort(this IPin pin, InterruptMode interruptMode = InterruptMode.None, ResistorMode resistorMode = ResistorMode.Disabled)
        {
            if (pin.Controller is IDigitalInputController controller)
            {
                return controller.CreateDigitalInputPort(pin, interruptMode, resistorMode);
            }

            throw new ArgumentException("Pin is not digital input capable");
        }

        public static IAnalogInputPort CreateAnalogInputPort(this IPin pin, int sampleCount, TimeSpan sampleInterval, Units.Voltage referenceVoltage)
        {
            if (pin.Controller is IAnalogInputController controller)
            {
                return controller.CreateAnalogInputPort(pin, sampleCount, sampleInterval, referenceVoltage);
            }

            throw new ArgumentException("Pin is not analog input capable");
        }

        public static IAnalogInputPort CreateAnalogInputPort(this IPin pin, int sampleCount)
        {
            if (pin.Controller is IAnalogInputController controller)
            {
                return controller.CreateAnalogInputPort(pin, sampleCount);
            }

            throw new ArgumentException("Pin is not analog input capable");
        }

        public static IPwmPort CreatePwmPort(this IPin pin, Frequency frequency, float dutyCycle = 0.5f, bool invert = false)
        {
            if (pin.Controller is IPwmOutputController controller)
            {
                return controller.CreatePwmPort(pin, frequency, dutyCycle, invert);
            }

            throw new ArgumentException("Pin is not PWM output capable");
        }
    }
}

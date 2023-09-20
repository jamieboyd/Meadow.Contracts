using Meadow.Units;
using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Abstraction for managing device channels
    /// </summary>
    public interface IDeviceChannelManager
    {
        /// <summary>
        /// Gets or sets a list of pins that are not usable by applications
        /// </summary>
        string[]? SystemReservedPins { get; set; }

        /// <summary>
        /// Reserves an IPin at run-time for a specified configuration
        /// </summary>
        /// <param name="pin"></param>
        /// <param name="configType"></param>
        /// <returns></returns>
        Tuple<bool, string> ReservePin(IPin pin, ChannelConfigurationType configType);
        /// <summary>
        /// Releases a reservation on an IPin at run-time
        /// </summary>
        /// <param name="pin"></param>
        /// <returns></returns>
        bool ReleasePin(IPin pin);
        /// <summary>
        /// Reserves an IPin for PWM use
        /// </summary>
        /// <param name="pin"></param>
        /// <param name="channelInfo"></param>
        /// <param name="frequency"></param>
        /// <returns></returns>
        Tuple<bool, string> ReservePwm(IPin pin, IPwmChannelInfo channelInfo, Frequency frequency);
        /// <summary>
        /// Method called before Meadow Core starts a PWM.  This allows hardware-specific actions like channel reservation and setup.
        /// </summary>
        /// <param name="info"></param>
        void BeforeStartPwm(IPwmChannelInfo info);
        /// <summary>
        /// Method called after Meadow Core starts a PWM.  This allows hardware-specific actions like channel reservation and setup.
        /// </summary>
        /// <param name="info"></param>
        /// <param name="ioController"></param>
        void AfterStartPwm(IPwmChannelInfo info, IMeadowIOController ioController);
    }
}

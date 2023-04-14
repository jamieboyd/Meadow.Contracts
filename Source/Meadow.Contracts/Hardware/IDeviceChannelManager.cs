using Meadow.Units;
using System;

namespace Meadow.Hardware
{
    public interface IDeviceChannelManager
    {
        string[]? SystemReservedPins { get; set; }

        Tuple<bool, string> ReservePin(IPin pin, ChannelConfigurationType configType);
        bool ReleasePin(IPin pin);
        Tuple<bool, string> ReservePwm(IPin pin, IPwmChannelInfo channelInfo, Frequency frequency);
        void BeforeStartPwm(IPwmChannelInfo info);
        void AfterStartPwm(IPwmChannelInfo info, IMeadowIOController ioController);
    }
}

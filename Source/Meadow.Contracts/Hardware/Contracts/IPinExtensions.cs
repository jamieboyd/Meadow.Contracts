using System;
using System.Linq;

namespace Meadow.Hardware
{
    public static class IPinExtensions
    {
        public static bool Supports<TChannel>(this IPin pin)
            where TChannel : IChannelInfo
        {
            var chan = pin.SupportedChannels.OfType<TChannel>().FirstOrDefault();
            return chan != null;
        }

        public static bool Supports<TChannel>(this IPin pin, Func<TChannel, bool> where)
            where TChannel : IChannelInfo
        {
            var chan = pin.SupportedChannels.OfType<TChannel>().Where(where).FirstOrDefault();
            return chan != null;
        }
    }
}

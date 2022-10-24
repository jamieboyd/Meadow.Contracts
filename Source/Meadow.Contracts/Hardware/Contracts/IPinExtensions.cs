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
    }
}

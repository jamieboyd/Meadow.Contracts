using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for a pin on the Meadow board.
    /// </summary>
    public interface IPin : IEquatable<IPin>
    {
        /// <summary>
        /// Supported channels
        /// </summary>
        IList<IChannelInfo>? SupportedChannels { get; }

        /// <summary>
        /// The name of the pin
        /// </summary>
        string Name { get; }

        /// <summary>
        /// The key object for the pin
        /// </summary>
        object Key { get; }

        /// <summary>
        /// To string 
        /// </summary>
        /// <returns>The pin name</returns>
        public string ToString() => Name;
    }
}
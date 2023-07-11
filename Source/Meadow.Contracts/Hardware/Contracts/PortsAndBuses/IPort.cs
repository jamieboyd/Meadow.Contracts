using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Represents a port that is associated with a specific channel and pin.
    /// </summary>
    /// <typeparam name="C">The type of channel associated with the port.</typeparam>
    public interface IPort<C> : IDisposable where C : IChannelInfo
    {
        /// <summary>
        /// Gets the channel associated with the port.
        /// </summary>
        C Channel { get; }

        /// <summary>
        /// Gets the pin associated with the port.
        /// </summary>
        IPin Pin { get; }
    }
}

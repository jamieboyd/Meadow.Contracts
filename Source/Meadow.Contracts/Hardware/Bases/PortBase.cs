using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Represents a base class for hardware ports.
    /// </summary>
    /// <typeparam name="C">The type of the channel information associated with the port.</typeparam>
    public abstract class PortBase<C> : IPort<C> where C : class, IChannelInfo
    {
        /// <summary>
        /// Indicates whether the port has been disposed.
        /// </summary>
        protected bool disposed = false;

        /// <summary>
        /// Gets the channel information associated with the port.
        /// </summary>
        public C Channel { get; }

        /// <summary>
        /// Gets or sets the pin associated with the port.
        /// </summary>
        public IPin Pin { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PortBase{C}"/> class.
        /// </summary>
        /// <param name="pin">The pin associated with the port.</param>
        /// <param name="channel">The channel information for the port.</param>
        /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
        protected PortBase(IPin pin, C channel)
        {
            Pin = pin ?? throw new ArgumentNullException(nameof(pin));
            Channel = channel ?? throw new ArgumentNullException(nameof(channel));
        }

        /// <summary>
        /// Releases the resources used by the port.
        /// </summary>
        /// <param name="disposing">A boolean value indicating whether the port is being disposed.</param>
        protected virtual void Dispose(bool disposing) { }

        /// <summary>
        /// Releases the resources used by the port.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}

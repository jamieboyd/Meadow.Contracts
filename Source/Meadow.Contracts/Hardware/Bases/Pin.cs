using System.Collections.Generic;

namespace Meadow.Hardware
{

    /// <summary>
    /// Provides base implementation for IO pins.
    /// </summary>
    public class Pin : IPin
    {
        public IList<IChannelInfo>? SupportedChannels { get; protected set; }

        public string Name { get; protected set; }
        /// <summary>
        /// Identifier that the parent Device can use to identify the I/O (address, port, pin, etc)
        /// </summary>
        /// <value>The key.</value>
        public object Key { get; protected set; }

        //public abstract IChannelInfo ActiveChannel { get; protected set; }

        public Pin(string name, object key, IList<IChannelInfo>? supportedChannels)
        {
            Name = name;
            Key = key;
            SupportedChannels = supportedChannels;
        }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Pin()
        {
            // make default non-callable
        }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public override string ToString()
        {
            return Name;
        }

        public void ReserveChannel<C>()
        {

        }
        public void ReleaseChannel()
        {

        }

        public virtual bool Equals(IPin other)
        {
            if (other == null) return false;

            return Key.Equals(other.Key);
        }

        public override bool Equals(object obj)
        {
            if (obj is IPin { } p)
            {
                return p.Equals(this);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Key.GetHashCode();
        }
    }
}
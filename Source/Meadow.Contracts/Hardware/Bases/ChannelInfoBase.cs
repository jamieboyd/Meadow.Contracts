using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Provides base functionality for channel types.
    /// </summary>
    public abstract class ChannelInfoBase
    {
        public string Name { get; protected set; }

        protected ChannelInfoBase(string name)
        {
            Name = name;
        }
    }

    public interface IChannelInfoBase
    {
        public string Name { get; protected set; }
    }
}

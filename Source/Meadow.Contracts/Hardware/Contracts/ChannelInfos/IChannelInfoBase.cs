namespace Meadow.Hardware
{
    /// <summary>
    /// Represents the base interface for channel information.
    /// </summary>
    public interface IChannelInfoBase
    {
        /// <summary>
        /// Gets or sets the name of the channel.
        /// </summary>
        string Name { get; protected set; }
    }
}
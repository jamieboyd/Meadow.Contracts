namespace Meadow.Hardware;

/// <summary>
/// Provides base functionality for channel types.
/// </summary>
public abstract class ChannelInfoBase
{
    /// <summary>
    /// Gets or sets the name of the channel
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// The ChannelInfoBase constructor
    /// </summary>
    /// <param name="name">The name of the channel.</param>
    protected ChannelInfoBase(string name)
    {
        Name = name;
    }
}

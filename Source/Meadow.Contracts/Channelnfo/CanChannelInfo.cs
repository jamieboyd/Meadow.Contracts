namespace Meadow.Hardware;

/// <summary>
/// Information about a Controller Area Network (CanChannelInfo) channel
/// </summary>
public class CanChannelInfo : DigitalChannelInfoBase, ICanChannelInfo
{
    /// <summary>
    /// Direction 
    /// </summary>
    public SerialDirectionType SerialDirection { get; protected set; }

    public CanChannelInfo(string name, SerialDirectionType serialDirection)
        : base(name, true, true, true, true, true, false)
    {
        this.SerialDirection = serialDirection;
    }

}

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

    /// <summary>
    /// Information about a Controller Area Network (CanChannelInfo) channel
    /// </summary>
    /// <param name="name">The name of the Can Channel</param>
    /// <param name="serialDirection">The direction of the Can Channel</param>

    public CanChannelInfo(string name, SerialDirectionType serialDirection)
        : base(name, true, true, true, true, true, false)
    {
        SerialDirection = serialDirection;
    }
}
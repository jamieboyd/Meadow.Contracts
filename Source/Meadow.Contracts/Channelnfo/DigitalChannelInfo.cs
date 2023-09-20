namespace Meadow.Hardware;

/// <summary>
/// Information about a digital channel's capabilities
/// </summary>
public class DigitalChannelInfo : DigitalChannelInfoBase
{
    /// <summary>
    /// Creates a new DigitalChannelInfo instance
    /// </summary>
    /// <param name="name"></param>
    /// <param name="inputCapable"></param>
    /// <param name="outputCapable"></param>
    /// <param name="interruptCapable"></param>
    /// <param name="pullDownCapable"></param>
    /// <param name="pullUpCapable"></param>
    /// <param name="inverseLogic"></param>
    /// <param name="interruptGroup"></param>
    public DigitalChannelInfo(
    string name,
        bool inputCapable = true,
        bool outputCapable = true,
        bool interruptCapable = true,
        bool pullDownCapable = true,
        bool pullUpCapable = true,
        bool inverseLogic = false,
        int? interruptGroup = null
    )
        : base(name, inputCapable, outputCapable, interruptCapable,
            pullDownCapable, pullUpCapable, inverseLogic, interruptGroup)
    {
    }
}

namespace Meadow.Hardware;

/// <summary>
/// Information about a digital channel's capabilities
/// </summary>
public class DigitalChannelInfo : DigitalChannelInfoBase
{
    /// <summary>
    /// Creates a new DigitalChannelInfo instance
    /// </summary>
    /// <param name="name">The name of the channel.</param>
    /// <param name="inputCapable">The channel's digital input capability.</param>
    /// <param name="outputCapable">The channel's digital output capability.</param>
    /// <param name="interruptCapable">The channel's digital interrupt capability.</param>
    /// <param name="pullDownCapable">The channel's internal pull-down resistor capability.</param>
    /// <param name="pullUpCapable">The channel's internal pull-up resistor capability.</param>
    /// <param name="inverseLogic">The channel has inverse boolean logic (low == true).</param>
    /// <param name="interruptGroup">The platform interrupt group association for the channel.</param>
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

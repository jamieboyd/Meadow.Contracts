namespace Meadow.Hardware;

/// <summary>
/// A base implementation of the IDigitalChannelInfo interface.
/// </summary>
public class DigitalChannelInfoBase : ChannelInfoBase, IDigitalChannelInfo
{
    /// <summary>
    /// Gets or sets the channel's digital input capability.
    /// </summary>
    public bool InputCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's digital output capability.
    /// </summary>
    public bool OutputCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's digital interrupt capability.
    /// </summary>
    public bool InterruptCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's internal pull-down resistor capability.
    /// </summary>
    public bool PullDownCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's internal pull-up resistor capability.
    /// </summary>
    public bool PullUpCapable { get; protected set; }
    /// <summary>
    /// Gets or sets whether the channel has inverse boolean logic (low == true).
    /// </summary>
    public bool InverseLogic { get; protected set; }
    /// <summary>
    /// When relevant, gets or sets any platform interrupt group association for the channel.
    /// </summary>
    public int? InterruptGroup { get; protected set; }

    /// <summary>
    /// Constructor for a DigitalChannelInfoBase
    /// </summary>
    /// <param name="name">The name of the channel.</param>
    /// <param name="inputCapable">The channel's digital input capability.</param>
    /// <param name="outputCapable">The channel's digital output capability.</param>
    /// <param name="interruptCapable">The channel's digital interrupt capability.</param>
    /// <param name="pullDownCapable">The channel's internal pull-down resistor capability.</param>
    /// <param name="pullUpCapable">The channel's internal pull-up resistor capability.</param>
    /// <param name="inverseLogic">The channel has inverse boolean logic (low == true).</param>
    /// <param name="interruptGroup">The platform interrupt group association for the channel.</param>
    protected DigitalChannelInfoBase(
        string name,
        bool inputCapable,
        bool outputCapable,
        bool interruptCapable,
        bool pullDownCapable,
        bool pullUpCapable,
        bool inverseLogic,
        int? interruptGroup = null)
        : base(name)
    {
        InputCapable = inputCapable;
        OutputCapable = outputCapable;
        InterruptCapable = interruptCapable;
        PullDownCapable = pullDownCapable;
        PullUpCapable = pullUpCapable;
        InverseLogic = inverseLogic;
        InterruptGroup = interruptGroup;
    }
}

namespace Meadow.Hardware;

/// <summary>
/// A base implementation of the IDigitalChannelInfo interface
/// </summary>
public class DigitalChannelInfoBase : ChannelInfoBase, IDigitalChannelInfo
{
    /// <summary>
    /// Gets or sets the channel's digital input capability
    /// </summary>
    public bool InputCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's digital output capability
    /// </summary>
    public bool OutputCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's digital interrupt capability
    /// </summary>
    public bool InterruptCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's internal pull-down resistor capability
    /// </summary>
    public bool PullDownCapable { get; protected set; }
    /// <summary>
    /// Gets or sets the channel's internal pull-up resistor capability
    /// </summary>
    public bool PullUpCapable { get; protected set; }
    /// <summary>
    /// Gets or sets whether the channel has inverse boolean logic (low == true)
    /// </summary>
    public bool InverseLogic { get; protected set; }
    /// <summary>
    /// When relevant, gets or sets any platform interrupt group association for the channel
    /// </summary>
    public int? InterruptGroup { get; protected set; }

    /// <summary>
    /// Contructor for a DigitalChannelInfoBase
    /// </summary>
    /// <param name="name"></param>
    /// <param name="inputCapable"></param>
    /// <param name="outputCapable"></param>
    /// <param name="interruptCapable"></param>
    /// <param name="pullDownCapable"></param>
    /// <param name="pullUpCapable"></param>
    /// <param name="inverseLogic"></param>
    /// <param name="interruptGroup"></param>
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

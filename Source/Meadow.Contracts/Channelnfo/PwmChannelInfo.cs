namespace Meadow.Hardware;

/// <summary>
/// Information about a Pulse Width Modulation (PWM) channel
/// </summary>
public class PwmChannelInfo : DigitalChannelInfoBase, IPwmChannelInfo
{
    /// <summary>
    /// The minimum pulse frequency supported by the channel
    /// </summary>
    public float MinimumFrequency { get; protected set; }
    /// <summary>
    /// The maximum pulse frequency supported by the channel
    /// </summary>
    public float MaximumFrequency { get; protected set; }
    /// <summary>
    /// Gets the OS system timer number used to drive the PWM
    /// </summary>
    public uint Timer { get; protected set; }
    /// <summary>
    /// Gets the OS timer channel used to drive the PWM
    /// </summary>
    public uint TimerChannel { get; protected set; }

    /// <summary>
    /// Creates a PwmChannelInfo instance
    /// </summary>
    /// <param name="name"></param>
    /// <param name="timer"></param>
    /// <param name="timerChannel"></param>
    /// <param name="minimumFrequency"></param>
    /// <param name="maximumFrequency"></param>
    /// <param name="pullDownCapable"></param>
    /// <param name="pullUpCapable"></param>
    public PwmChannelInfo(string name,
        uint timer,
        uint timerChannel,
        float minimumFrequency = 0,
        float maximumFrequency = 100000,
        bool pullDownCapable = false, // does this mean anything in PWM?
        bool pullUpCapable = false) // ibid
        : base(
            name,
            inputCapable: true,
            outputCapable: true,
            interruptCapable: false, // ?? i mean, technically, yes, but will we have events?
            pullDownCapable: pullDownCapable,
            pullUpCapable: pullUpCapable,
            inverseLogic: false) //TODO: switch to C# 7.2+ to get rid of trailing names
    {
        Timer = timer;
        TimerChannel = timerChannel;
        MinimumFrequency = minimumFrequency;
        MaximumFrequency = maximumFrequency;
    }
}

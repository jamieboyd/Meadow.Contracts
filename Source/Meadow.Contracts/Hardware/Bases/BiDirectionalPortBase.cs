using System;

namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for BiDirectional Ports; digital ports 
/// that can be both input and output.
/// </summary>
public abstract class BiDirectionalPortBase : DigitalPortBase, IBiDirectionalPort, IDisposable
{
    /// <summary>
    /// Gets the initial state of the port
    /// </summary>
    public bool InitialState { get; }
    /// <summary>
    /// Gets the initial output type of the port
    /// </summary>
    public OutputType InitialOutputType { get; }
    /// <summary>
    /// Gets the resistor mode of the port
    /// </summary>
    public virtual ResistorMode Resistor { get; set; }
    /// <summary>
    /// Gets or sets the current state of the port
    /// </summary>
    public abstract bool State { get; set; }
    /// <summary>
    /// Gets or sets the current direction of the port
    /// </summary>
    public abstract PortDirectionType Direction { get; set; }

    /// <summary>
    /// Constructor for the BiDirectionalPortBase
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    /// <param name="initialState"></param>
    /// <param name="resistorMode"></param>
    /// <param name="initialDirection"></param>
    protected BiDirectionalPortBase(
        IPin pin,
        IDigitalChannelInfo channel,
        bool initialState,
        ResistorMode resistorMode = ResistorMode.Disabled,
        PortDirectionType initialDirection = PortDirectionType.Input)
        : this(pin, channel, initialState, resistorMode, initialDirection, initialOutputType: OutputType.PushPull)
    {
    }

    /// <summary>
    /// Constructor for the BiDirectionalPortBase
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    /// <param name="initialState"></param>
    /// <param name="resistorMode"></param>
    /// <param name="initialDirection"></param>
    /// <param name="initialOutputType"></param>
    protected BiDirectionalPortBase(
        IPin pin,
        IDigitalChannelInfo channel,
        bool initialState,
        ResistorMode resistorMode,
        PortDirectionType initialDirection,
        OutputType initialOutputType)
        : base(pin, channel)
    {
        InitialState = initialState;
        Resistor = resistorMode;
        Direction = initialDirection;
        InitialOutputType = initialOutputType;
    }
}

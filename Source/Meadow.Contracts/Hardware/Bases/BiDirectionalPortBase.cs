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
    /// <inheritdoc/>
    public abstract PortDirectionType Direction { get; set; }

    /// <summary>
    /// Constructor for the BiDirectionalPortBase
    /// </summary>
    /// <param name="pin">The pin associated with the port.</param>
    /// <param name="channel">The channel information for the port.</param>
    /// <param name="initialState">The initial state of the port.</param>
    /// <param name="resistorMode">The resistor mode of the port.</param>
    /// <param name="initialDirection">The current direction of the port.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
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
    /// <param name="pin">The pin associated with the port.</param>
    /// <param name="channel">The channel information for the port.</param>
    /// <param name="initialState">The initial state of the port.</param>
    /// <param name="resistorMode">The resistor mode of the port.</param>
    /// <param name="initialDirection">The current direction of the port.</param>
    /// <param name="initialOutputType">The initial output type of the port.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
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

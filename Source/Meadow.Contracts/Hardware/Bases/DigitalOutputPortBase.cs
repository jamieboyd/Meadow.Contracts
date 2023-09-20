using System;

namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for digital output ports.
/// </summary>
public abstract class DigitalOutputPortBase : DigitalPortBase, IDigitalOutputPort
{
    /// <summary>
    /// The initial state of the port.
    /// </summary>
    public bool InitialState { get; protected set; }
    /// <summary>
    /// Gets or sets the initial OutputType for the port
    /// </summary>
    public OutputType InitialOutputType { get; protected set; }

    /// <summary>
    /// Gets or sets the current state of the port
    /// </summary>
    public abstract bool State { get; set; }

    /// <summary>
    /// Constructor for the DigitalOutputPortBase
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    /// <param name="initialState"></param>
    /// <param name="initialOutputType"></param>
    protected DigitalOutputPortBase(IPin pin, IDigitalChannelInfo channel, bool initialState, OutputType initialOutputType)
        : base(pin, channel)
    {
        InitialState = initialState;
        InitialOutputType = initialOutputType;
    }
}

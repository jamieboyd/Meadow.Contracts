using System;

namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for digital output ports.
/// </summary>
public abstract class DigitalOutputPortBase : DigitalPortBase, IDigitalOutputPort
{
    /// <inheritdoc/>
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
    /// <param name="pin">The pin associated with the port.</param>
    /// <param name="channel">The channel information for the port.</param>
    /// <param name="initialState">The initial state of the port, either low (false) or high (true)</param>
    /// <param name="initialOutputType">The initial output configuration for the port</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
    protected DigitalOutputPortBase(IPin pin, IDigitalChannelInfo channel, bool initialState, OutputType initialOutputType)
        : base(pin, channel)
    {
        InitialState = initialState;
        InitialOutputType = initialOutputType;
    }
}

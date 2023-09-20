using System;

namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for digital input ports.
/// </summary>
public abstract class DigitalInputPortBase : DigitalPortBase, IDigitalInputPort
{

    /// <summary>
    /// Gets the current state of the port
    /// </summary>
    public abstract bool State { get; }
    /// <summary>
    /// Gets or sets the internal resistor mode of the port
    /// </summary>
    public abstract ResistorMode Resistor { get; set; }

    /// <summary>
    /// Constructor for the DigitalInputPortBase
    /// </summary>
    /// <param name="pin">The pin associated with the port.</param>
    /// <param name="channel">The channel information for the port.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
    protected DigitalInputPortBase(
        IPin pin,
        IDigitalChannelInfo channel
        )
        : base(pin, channel)
    {
    }
}
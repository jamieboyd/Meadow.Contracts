using System;

namespace Meadow.Hardware;

/// <summary>
/// DigitalPortBase provides a base implementation for much of the 
/// common tasks of classes implementing IDigitalPort.
/// </summary>
public abstract class DigitalPortBase : PortBase<IDigitalChannelInfo>, IDigitalPort
{
    /// <summary>
    /// Gets or sets the IDigitalChannelInfo for the port
    /// </summary>
    public new IDigitalChannelInfo Channel { get; protected set; }

    /// <summary>
    /// Gets whether or not the channel has inverse boolean logic (low == true)
    /// </summary>
    protected bool InverseLogic { get; }

    /// <summary>
    /// Constructor for a DigitalPortBase
    /// </summary>
    /// <param name="pin">The pin associated with the port.</param>
    /// <param name="channel">The channel information for the port.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
    protected DigitalPortBase(IPin pin, IDigitalChannelInfo channel)
        : base(pin, channel)
    {
        InverseLogic = channel.InverseLogic;
        Channel = channel;
    }
}

using System;

namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for much of the common tasks of 
/// implementing IAnalogPort
/// </summary>
public abstract class AnalogPortBase : PortBase<IAnalogChannelInfo>, IAnalogPort
{
    /// <summary>
    /// Constructor for an Analog port base instance
    /// </summary>
    /// <param name="pin">The pin associated with the port.</param>
    /// <param name="channel">The channel information for the port.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="pin"/> or <paramref name="channel"/> is <c>null</c>.</exception>
    protected AnalogPortBase(IPin pin, IAnalogChannelInfo channel)
        : base(pin, channel)
    { }
}

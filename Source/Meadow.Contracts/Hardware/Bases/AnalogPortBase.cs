namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for much of the common tasks of 
/// implementing IAnalogPort
/// </summary>
public abstract class AnalogPortBase : PortBase<IAnalogChannelInfo>, IAnalogPort
{
    /// <summary>
    /// Constructore for an Alalog port base instance
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    protected AnalogPortBase(IPin pin, IAnalogChannelInfo channel)
        : base(pin, channel)
    { }
}

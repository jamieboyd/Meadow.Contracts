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
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    protected DigitalInputPortBase(
        IPin pin,
        IDigitalChannelInfo channel
        )
        : base(pin, channel)
    {
    }
}
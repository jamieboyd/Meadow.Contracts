using System;
using System.Collections.Generic;

namespace Meadow.Hardware;

/// <summary>
/// Provides a base implementation for BiDirectional Ports; digital ports 
/// that can be both input and output.
/// </summary>
public abstract class BiDirectionalPortBase : DigitalPortBase, IBiDirectionalPort, IDigitalInterruptPort, IDisposable
{
    /// <summary>
    /// Event raised when the port value changes
    /// </summary>
    public event EventHandler<DigitalPortResult> Changed = delegate { };

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
    public ResistorMode Resistor { get; }
    /// <summary>
    /// Gets a list of port State observers
    /// </summary>
    protected List<IObserver<DigitalPortResult>> Observers { get; private set; } = new List<IObserver<DigitalPortResult>>();

    /// <summary>
    /// Gets or sets the current state of the port
    /// </summary>
    public abstract bool State { get; set; }
    /// <summary>
    /// Gets or sets the current direction of the port
    /// </summary>
    public abstract PortDirectionType Direction { get; set; }
    /// <summary>
    /// Gets or sets the debounce duration of the port
    /// </summary>
    public abstract TimeSpan DebounceDuration { get; set; }
    /// <summary>
    /// Gets or sets the glitch filter duration of the port
    /// </summary>
    public abstract TimeSpan GlitchDuration { get; set; }

    /// <summary>
    /// Gets or sets a value indicating the type of interrupt monitoring this input.
    /// </summary>
    /// <value><c>true</c> if interrupt enabled; otherwise, <c>false</c>.</value>
    public InterruptMode InterruptMode { get; protected set; }

    /// <summary>
    /// Constructor for the BiDirectionalPortBase
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    /// <param name="initialState"></param>
    /// <param name="interruptMode"></param>
    /// <param name="resistorMode"></param>
    /// <param name="initialDirection"></param>
    protected BiDirectionalPortBase(
        IPin pin,
        IDigitalChannelInfo channel,
        bool initialState,
        InterruptMode interruptMode = InterruptMode.None,
        ResistorMode resistorMode = ResistorMode.Disabled,
        PortDirectionType initialDirection = PortDirectionType.Input)
        : this(pin, channel, initialState, interruptMode, resistorMode, initialDirection, debounceDuration: TimeSpan.Zero, glitchDuration: TimeSpan.Zero, initialOutputType: OutputType.PushPull)
    {
    }

    /// <summary>
    /// Constructor for the BiDirectionalPortBase
    /// </summary>
    /// <param name="pin"></param>
    /// <param name="channel"></param>
    /// <param name="initialState"></param>
    /// <param name="interruptMode"></param>
    /// <param name="resistorMode"></param>
    /// <param name="initialDirection"></param>
    /// <param name="debounceDuration"></param>
    /// <param name="glitchDuration"></param>
    /// <param name="initialOutputType"></param>
    protected BiDirectionalPortBase(
        IPin pin,
        IDigitalChannelInfo channel,
        bool initialState,
        InterruptMode interruptMode,
        ResistorMode resistorMode,
        PortDirectionType initialDirection,
        TimeSpan debounceDuration,
        TimeSpan glitchDuration,
        OutputType initialOutputType)
        : base(pin, channel)
    {
        InterruptMode = interruptMode;
        InitialState = initialState;
        Resistor = resistorMode;
        Direction = initialDirection;
        DebounceDuration = debounceDuration;   // Don't trigger WireInterrupt call via property
        GlitchDuration = glitchDuration;       // Don't trigger WireInterrupt call via property
        InitialOutputType = initialOutputType;
    }

    /// <summary>
    /// Raises the Changed event and notifies all observers of a state change
    /// </summary>
    /// <param name="changeResult"></param>
    protected void RaiseChangedAndNotify(DigitalPortResult changeResult)
    {
        if (disposed) return;

        Changed?.Invoke(this, changeResult);
        // TODO: implement Subscribe pattern (see DigitalInputPortBase)
        // _observers.ForEach(x => x.OnNext(changeResult));
    }
}

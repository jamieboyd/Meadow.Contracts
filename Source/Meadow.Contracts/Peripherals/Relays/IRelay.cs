using System;

namespace Meadow.Peripherals.Relays;

/// <summary>
/// Electrical switch (usually mechanical) that switches on an isolated circuit
/// </summary>
public interface IRelay
{
    /// <summary>
    /// Gets or sets a value indicating whether the relay is in an open state.
    /// </summary>
    public bool IsOpen
    {
        get => State == RelayState.Open;
        set => State = value ? RelayState.Open : RelayState.Closed;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the relay is in a closed state.
    /// </summary>
    public bool IsClosed
    {
        get => State == RelayState.Closed;
        set => State = value ? RelayState.Closed : RelayState.Open;
    }

    /// <summary>
    /// Gets or sets the state of the relay.
    /// </summary>
    RelayState State { get; set; }

    /// <summary>
    /// Returns relay type.
    /// </summary>
    RelayType Type { get; }

    /// <summary>
    /// Toggles the relay on or off.
    /// </summary>
    void Toggle();

    /// <summary>
    /// Event raised after relay state change
    /// </summary>
    event EventHandler<RelayState> OnChanged;
}

using System;

namespace Meadow.Hardware;

/// <summary>
/// Data relating to a WiFi disconnect event.
/// </summary>
public class NetworkDisconnectionEventArgs : EventArgs
{
    /// <summary>
    /// Date and time the event was generated.
    /// </summary>
    public DateTime When { get; private set; }

    /// <summary>
    /// Disconnect reason
    /// </summary>
    public string Reason { get; }

    /// <summary>
    /// Construct a NetworkDisconnectionEventArgs object.
    /// </summary>
    public NetworkDisconnectionEventArgs(string reason)
    {
        When = DateTime.UtcNow;
        Reason = reason;
    }
}

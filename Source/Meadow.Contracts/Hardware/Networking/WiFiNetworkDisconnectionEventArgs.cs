namespace Meadow.Hardware;

/// <summary>
/// Provides data for events related to WiFi network disconnection
/// </summary>
public class WiFiNetworkDisconnectionEventArgs : NetworkDisconnectionEventArgs
{
    /// <summary>
    /// Creates a WifiNetworkDisconnectionEventArgs
    /// </summary>
    /// <param name="reason">The reason for disconnection</param>
    public WiFiNetworkDisconnectionEventArgs(WiFiDisconnectedReason reason)
        : base(GetReasonString(reason))
    {
    }

    private static string GetReasonString(WiFiDisconnectedReason reason)
    {
        return reason switch
        {
            WiFiDisconnectedReason.Unspecified => "Unspecified",
            WiFiDisconnectedReason.Inactivity => "Disconnected due to inactivity",
            WiFiDisconnectedReason.TooManyDevicesConnected => "Too many devices already connected to the Access Point",
            WiFiDisconnectedReason.ManualDisconnect => "Adapter was commanded to disconnect",
            WiFiDisconnectedReason.IncorrectPasscode => "Incorrect passcode provided",
            WiFiDisconnectedReason.InsufficientSignal => "Insufficient signal to connect",
            WiFiDisconnectedReason.AccessPointDisconnected => "Access point dropped the connection",
            WiFiDisconnectedReason.AccessPointNotFound => "Access point not found",
            _ => $"Undefined Reason ({reason})",
        };
    }

    /// <summary>
    /// Gets or sets the reason for WiFi network disconnection.
    /// </summary>
    public WiFiDisconnectedReason WiFiReason { get; }
}

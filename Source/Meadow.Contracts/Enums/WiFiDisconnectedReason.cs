namespace Meadow.Hardware;

/// <summary>
/// Reasons for WiFi network disconnection
/// </summary>
public enum WiFiDisconnectedReason
{
    /// <summary>
    /// Unspecified reason for disconnection
    /// </summary>
    Unspecified = 1,

    /// <summary>
    /// Disconnection due to authenticated leave
    /// </summary>
    AuthenticatedLeave = 3,

    /// <summary>
    /// Disconnection due to inactivity
    /// </summary>
    Inactivity = 4,

    /// <summary>
    /// Disconnection because too many devices are connected
    /// </summary>
    TooManyDevicesConnected = 5,

    /// <summary>
    /// Disconnection initiated manually
    /// </summary>
    ManualDisconnect = 8,

    /// <summary>
    /// Disconnection due to incorrect passcode
    /// </summary>
    IncorrectPasscode = 15,

    /// <summary>
    /// Disconnection due to insufficient signal
    /// </summary>
    InsufficientSignal = 33,

    /// <summary>
    /// Disconnection because the access point was disconnected
    /// </summary>
    AccessPointDisconnected = 200,

    /// <summary>
    /// Disconnection because the access point was not found
    /// </summary>
    AccessPointNotFound = 201,
}

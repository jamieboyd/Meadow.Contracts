namespace Meadow;

/// <summary>
/// Enumeration of the state of the device's connection to Meadow.Cloud
/// </summary>
public enum CloudConnectionState
{
    /// <summary>
    /// The cloud connection state is not known
    /// </summary>
    Unknown,
    /// <summary>
    /// The device is not currently connected to Meadow.Cloud
    /// </summary>
    Disconnected,
    /// <summary>
    /// The device is authenticating with Meadow.Cloud
    /// </summary>
    Authenticating,
    /// <summary>
    /// The device is connecting to Meadow.Cloud
    /// </summary>
    Connecting,
    /// <summary>
    /// The device is subscribing to MQTT topics
    /// </summary>
    Subscribing,
    /// <summary>
    /// The device is connected to Meadow.Cloud
    /// </summary>
    Connected,
    /// <summary>
    /// State machine is paused for an internal operation
    /// </summary>
    Paused
}

/// <summary>
/// Enumeration of the state of the IUpdateService
/// </summary>
public enum UpdateState
{
    /// <summary>
    /// The service is not running (either not started, forcibly stopped, or in a unrecoverable failed state)
    /// </summary>
    Dead,
    /// <summary>
    /// The service is not currently connected to a server
    /// </summary>
    Disconnected,
    /// <summary>
    /// the service is authenticating with the server
    /// </summary>
    Authenticating,
    /// <summary>
    /// The service is connecting to the server
    /// </summary>
    Connecting,
    /// <summary>
    /// The service is connected to the server
    /// </summary>
    Connected,
    /// <summary>
    /// The service is connected and idle, waiting on server state notifications
    /// </summary>
    Idle,
    /// <summary>
    /// An update is currently available on the server
    /// </summary>
    UpdateAvailable,
    /// <summary>
    /// An update package is actively being downloaded
    /// </summary>
    DownloadingFile,
    /// <summary>
    /// An update package is in the process of being applied
    /// </summary>
    UpdateInProgress
}

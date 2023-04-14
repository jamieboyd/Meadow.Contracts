namespace Meadow.Update;

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

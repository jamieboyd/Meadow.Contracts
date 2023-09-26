namespace Meadow.Update;

/// <summary>
/// Provides an abstraction for settings passed to the Meadow Update Service
/// </summary>
public interface IUpdateSettings
{
    /// <summary>
    /// Gets the desired enabled state of the service
    /// </summary>
    public bool Enabled { get; set; }
    /// <summary>
    /// Gets the address of the Update (MQTT) server to use
    /// </summary>
    public string UpdateServer { get; set; }
    /// <summary>
    /// Gets the port of the Update (MQTT) server to use
    /// </summary>
    public int UpdatePort { get; set; }
    /// <summary>
    /// Gets the Organization the device is registered to
    /// </summary>
    public string Organization { get; set; }
    /// <summary>
    /// Gets the root MQTT topic to subscribe to for updates
    /// </summary>
    public string RootTopic { get; set; }
    /// <summary>
    /// Reconnect period used when a disconnection from the Update server occurs
    /// </summary>
    public int CloudConnectRetrySeconds { get; set; }
    /// <summary>
    /// Gets the preference for using authentication when connecting to the Update server
    /// </summary>
    public bool UseAuthentication { get; set; }
}
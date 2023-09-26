namespace Meadow.Cloud;

/// <summary>
/// An abstraction for connection settings for the Meadow.Cloud service
/// </summary>
public interface IMeadowCloudSettings
{
    /// <summary>
    /// The host name to use for authentication
    /// </summary>
    string Hostname { get; set; }
    /// <summary>
    /// The host name used for data exchange
    /// </summary>
    string DataHostname { get; set; }
    /// <summary>
    /// Enable to send health metrics to Meadow.Cloud
    /// </summary>
    bool EnableHealthMetrics { get; set; }
    /// <summary>
    /// Interval (in minutes) to send health metrics
    /// </summary>
    int HealthMetricsInterval { get; set; }
}
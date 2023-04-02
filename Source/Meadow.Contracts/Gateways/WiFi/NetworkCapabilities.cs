namespace Meadow;

/// <summary>
/// Describes a device's network capabilities
/// </summary>
public class NetworkCapabilities
{
    /// <summary>
    /// Gets a device's WiFi capabilities
    /// </summary>
    public bool HasWiFi { get; protected set; }
    /// <summary>
    /// Gets a device's wired etehrnet capabilities
    /// </summary>
    public bool HasEthernet { get; protected set; }

    /// <summary>
    /// Creates a NetworkCapabilities instance
    /// </summary>
    /// <param name="hasWifi"></param>
    /// <param name="hasEthernet"></param>
    public NetworkCapabilities(
        bool hasWifi,
        bool hasEthernet)
    {
        this.HasWiFi = hasWifi;
        this.HasEthernet = hasEthernet;
    }
}


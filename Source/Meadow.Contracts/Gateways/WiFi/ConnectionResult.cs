namespace Meadow.Gateway.WiFi;

/// <summary>
/// Describes the result of an attempted WiFi network connection.
/// </summary>
public class ConnectionResult
{
    /// <summary>
    /// Connecrtion status.
    /// </summary>
    public ConnectionStatus ConnectionStatus { get; protected set; }

    private ConnectionResult()
    {
    }

    /// <summary>
    /// Create a new ConnectionResult object.
    /// </summary>
    /// <param name="connectionStatus">Status of the connection attempt.</param>
    public ConnectionResult(ConnectionStatus connectionStatus)
    {
        ConnectionStatus = connectionStatus;
    }
}

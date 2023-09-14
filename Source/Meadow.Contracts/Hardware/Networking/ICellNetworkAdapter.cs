using Meadow.Networking;
namespace Meadow.Hardware;

/// <summary>
/// Provides an abstraction for a cellular INetworkAdapter
/// </summary>
public interface ICellNetworkAdapter : INetworkAdapter
{
    /// <summary>
    /// Gets the adapter's IMEI
    /// </summary>
    string Imei { get; }
    /// <summary>
    /// Gets the adapter's CSQ
    /// </summary>
    string Csq { get; }
    /// <summary>
    /// Gets the adapter's AT comman output
    /// </summary>
    string AtCmdsOutput { get; }

    /// <summary>
    /// Scans for networks the Adapter detects
    /// </summary>
    /// <returns>A list of CellNetworks</returns>
    CellNetwork[] Scan();

    /// <summary>
    /// Get current signal quality
    /// </summary>
    /// <param name="timeout"></param>
    /// <return>Cell signal quality</return>
    double GetSignalQuality(int timeout = 10);

    /// <summary>
    /// Scan available networks,
    /// this method is used without entering the "Scan Mode"
    /// </summary>
    /// <param name="timeout"></param>
    /// <returns>A list of CellNetworks</returns>
    CellNetwork[] ScanNetwork(int timeout = 30);
}

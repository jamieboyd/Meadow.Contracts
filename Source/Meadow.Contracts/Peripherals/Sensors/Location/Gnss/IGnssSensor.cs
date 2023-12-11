using System;

namespace Meadow.Peripherals.Sensors.Location.Gnss;

/// <summary>
/// Interface describing a Global navigation satellite system (GNSS) sensor
/// </summary>
public interface IGnssSensor
{
    /// <summary>
    /// Raised when new GNSS data is available
    /// </summary>
    public event EventHandler<IGnssResult> GnssDataReceived;

    /// <summary>
    /// Supported GNSS result types
    /// </summary>
    public IGnssResult[] SupportedResultTypes { get; }

    /// <summary>
    /// Start updating GNSS data
    /// </summary>
    public void StartUpdating();

    /// <summary>
    /// Stop updating GNSS data
    /// </summary>
    public void StopUpdating();
}
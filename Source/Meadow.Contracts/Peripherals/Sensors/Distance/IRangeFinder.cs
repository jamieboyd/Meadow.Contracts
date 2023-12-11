using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Distance;

/// <summary>
/// Interface for distance sensors classes.
/// </summary>
public interface IRangeFinder : ISamplingSensor<Length>
{
    /// <summary>
    /// Sends a trigger signal
    /// </summary>
    void MeasureDistance();

    /// <summary>
    /// Last value read from the sensor
    /// </summary>
    Length? Distance { get; }
}
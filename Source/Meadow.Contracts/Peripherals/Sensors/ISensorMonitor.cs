namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Represents a sensor monitor interface for starting and stopping sensor sampling.
/// </summary>
public interface ISensorMonitor
{
    /// <summary>
    /// Starts sensor sampling.
    /// </summary>
    /// <param name="sensor">Sensor to start sampling</param>
    void StartSampling(ISensor sensor);

    /// <summary>
    /// Stops sensor sampling.
    /// </summary>
    /// <param name="sensor">Sensor to stop sampling</param>
    void StopSampling(ISensor sensor);
}

using System;

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Represents a sensor monitor interface for starting and stopping sensor sampling.
/// </summary>
public interface ISensorMonitor
{
    /// <summary>
    /// Raised when a monitored sensor is read
    /// </summary>
    event EventHandler<object> SampleAvailable;

    /// <summary>
    /// Starts sensor sampling.
    /// </summary>
    /// <param name="sensor">Sensor to start sampling</param>
    void StartSampling(ISamplingSensor sensor);

    /// <summary>
    /// Stops sensor sampling.
    /// </summary>
    /// <param name="sensor">Sensor to stop sampling</param>
    void StopSampling(ISamplingSensor sensor);
}

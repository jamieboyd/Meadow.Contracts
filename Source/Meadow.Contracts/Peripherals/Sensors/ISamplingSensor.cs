using System;

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Abstraction for a sampling/observable sensor
/// </summary>
public interface ISamplingSensor<UNIT> : ISensor<UNIT>, ISamplingSensor
    where UNIT : struct
{
    /// <summary>
    /// Raised when a change in light is detected.
    /// </summary>
    event EventHandler<IChangeResult<UNIT>> Updated;
}

/// <summary>
/// Abstraction for a sampling/observable sensor
/// </summary>
public interface ISamplingSensor
{
    /// <summary>
    /// A `TimeSpan` that specifies how long to wait between readings
    /// </summary>
    public TimeSpan UpdateInterval { get; }

    /// <summary>
    /// Gets a value indicating whether the sensor is currently sampling
    /// </summary>
    /// <value>true if sampling, otherwise, false</value>
    public bool IsSampling { get; }

    /// <summary>
    /// Starts updating the sensor on the updateInterval frequency specified
    /// </summary>
    /// <param name="updateInterval">A TimeSpan that specifies how long to
    /// wait between readings</param>
    public void StartUpdating(TimeSpan? updateInterval = null);

    /// <summary>
    /// Stops sampling the sensor
    /// </summary>
    public void StopUpdating();
}
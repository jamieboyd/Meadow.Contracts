using System.Collections.Generic;

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Represents a sensor service interface for registering sensors.
/// </summary>
public interface ISensorService
{
    /// <summary>
    /// Registers a sampling sensor with the sensor service.
    /// </summary>
    /// <param name="sensor">The sensor to register.</param>
    void RegisterSensor(ISensor sensor);

    /// <summary>
    /// Gets all registered sensors of a specified type
    /// </summary>
    /// <typeparam name="TSensor">The type of sensor to search for</typeparam>
    IEnumerable<TSensor> GetSensorsOfType<TSensor>() where TSensor : ISensor;
    /// <summary>
    /// Gets all registered sensors that can provide data of a specified unit type
    /// </summary>
    /// <typeparam name="TUnit">The unit type of the sensor data to search for</typeparam>
    IEnumerable<ISensor> GetSensorsWithData<TUnit>() where TUnit : struct;
}
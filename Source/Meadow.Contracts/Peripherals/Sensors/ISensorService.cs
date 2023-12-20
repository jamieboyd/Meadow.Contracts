using System;
using System.Collections.Generic;

namespace Meadow.Peripherals.Sensors;

public enum SimulationBehavior
{
    RandomWalk,
    Sawtooth,
    Sine
}

public interface ISimulatedSensor
{
    SimulationBehavior[] SupportedBehaviors { get; }
    Type ValueType { get; }
    void SetSensorValue(object value);
    void Start(SimulationBehavior behavior);
}

public interface ISimulationService
{
    ISimulatedSensor[] Sensors { get; }
    void StopAll();
}

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
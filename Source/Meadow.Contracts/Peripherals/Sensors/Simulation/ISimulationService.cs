namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Represents a simulation service that manages simulated sensors.
/// </summary>
public interface ISimulationService
{
    /// <summary>
    /// Gets an array of simulated sensors managed by the simulation service.
    /// </summary>
    ISimulatedSensor[] Sensors { get; }

    /// <summary>
    /// Stops all ongoing simulations for all sensors.
    /// </summary>
    void StopAll();
}

namespace Meadow.Peripherals.Sensors;

/// <summary>
/// Represents different simulation behaviors for a simulated sensor.
/// </summary>
public enum SimulationBehavior
{
    /// <summary>
    /// The sensor does not support any internal simulation behavior
    /// </summary>
    None,
    /// <summary>
    /// Simulates a random walk behavior for the sensor's value.
    /// </summary>
    RandomWalk,
    /// <summary>
    /// Simulates a sawtooth waveform behavior for the sensor's value.
    /// </summary>
    Sawtooth,
    /// <summary>
    /// Simulates a sine waveform behavior for the sensor's value.
    /// </summary>
    Sine
}

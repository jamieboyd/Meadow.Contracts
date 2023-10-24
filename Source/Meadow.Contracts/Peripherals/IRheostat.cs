using Meadow.Units;

namespace Meadow.Hardware;

/// <summary>
/// Represents an adjustable resistor (rheostat).
/// </summary>
public interface IRheostat
{
    /// <summary>
    /// Gets the maximum resistance of the rheostat.
    /// </summary>
    Resistance MaxResistance { get; }

    /// <summary>
    /// Gets or sets the current resistance of the rheostat.
    /// </summary>
    Resistance Resistance { get; set; }
}

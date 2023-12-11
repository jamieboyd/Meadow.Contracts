using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Environmental;

/// <summary>
/// Gas ressistance interface requirements.
/// </summary>
public interface IGasResistanceSensor : ISamplingSensor<Resistance>
{
    /// <summary>
    /// Last value read from the gas resistance sensor.
    /// </summary>
    Resistance? GasResistance { get; }
}
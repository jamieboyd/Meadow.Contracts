namespace Meadow.Peripherals.Leds;

/// <summary>
/// Enumeration representing the electrical configuration of LEDs in a common package.
/// </summary>
public enum CommonType
{
    /// <summary>
    /// The cathode is electrically shared among the LEDs
    /// </summary>
    CommonCathode,
    /// <summary>
    /// The anode is electrically shared among the LEDs
    /// </summary>
    CommonAnode
}
using System.Threading.Tasks;

namespace Meadow;

/// <summary>
/// Provides an abstraction for peripherals that can be turned on and off
/// </summary>
public interface IPowerControllablePeripheral
{
    /// <summary>
    /// Powers on the peripheral
    /// </summary>
    /// <returns></returns>
    Task PowerOn();

    /// <summary>
    /// Powers off the peripheral
    /// </summary>
    /// <returns></returns>
    Task PowerOff();
}

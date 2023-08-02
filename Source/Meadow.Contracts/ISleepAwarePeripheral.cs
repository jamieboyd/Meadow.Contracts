using System.Threading;
using System.Threading.Tasks;

namespace Meadow;

/// <summary>
/// Provides an abstraction for peripherals that can be notified of sleep state changes
/// </summary>
public interface ISleepAwarePeripheral
{
    /// <summary>
    /// Called before the platform goes into Sleep state
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task BeforeSleep(CancellationToken cancellationToken);
    /// <summary>
    /// Called after the platform returns to Wake state
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public Task AfterWake(CancellationToken cancellationToken);
}

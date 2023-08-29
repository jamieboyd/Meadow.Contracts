using System.Threading.Tasks;

namespace Meadow.Cloud;

/// <summary>
/// Logic responsible for reporting device health metrics to Meadow.Cloud.
/// </summary>
public interface IHealthReporter
{
    /// <summary>
    /// Starts the health reporter based on the desired interval.
    /// </summary>
    /// <param name="interval">In minutes</param>
    void Start(int interval);

    /// <summary>
    /// Can be called to manually send a health report event.
    /// </summary>
    /// <returns></returns>
    Task Send();
}
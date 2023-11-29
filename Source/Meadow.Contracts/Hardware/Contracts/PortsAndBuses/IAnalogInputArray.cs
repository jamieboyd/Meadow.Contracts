namespace Meadow.Hardware;

/// <summary>
/// Contract for an array of analog input values
/// </summary>
public interface IAnalogInputArray
{
    /// <summary>
    /// Gets the last set of retrieved analog values
    /// </summary>
    double[] CurrentValues { get; }
    /// <summary>
    /// Refreshes the CurrentValues property
    /// </summary>
    void Refresh();
}

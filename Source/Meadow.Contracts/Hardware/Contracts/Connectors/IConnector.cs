using Meadow.Hardware;

namespace Meadow;
/// <summary>
/// An interface for a named collection of pins
/// </summary>
public interface IConnector
{
    /// <summary>
    /// The Connector's name
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The pins in the Connector
    /// </summary>
    public IPinDefinitions Pins { get; }
}

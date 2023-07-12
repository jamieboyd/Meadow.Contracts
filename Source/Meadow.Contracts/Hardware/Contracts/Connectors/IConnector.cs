namespace Meadow;

using Meadow.Hardware;

public interface IConnector
{
    public string Name { get; }
    public IPinDefinitions Pins { get; }
}

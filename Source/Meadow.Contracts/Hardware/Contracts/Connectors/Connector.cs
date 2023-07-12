namespace Meadow;

using Meadow.Hardware;
using System.Linq;

public abstract class Connector<TPinDefinition> : IConnector, IIOController<TPinDefinition>
    where TPinDefinition : IPinDefinitions
{
    public string Name { get; }
    public TPinDefinition Pins { get; }
    IPinDefinitions IConnector.Pins => Pins;

    protected Connector(string name, TPinDefinition pins)
    {
        name = name;
        Pins = pins;
    }

    public IPin? GetPin(string pinName)
    {
        return Pins.AllPins.FirstOrDefault(p => p.Name == pinName || p.Key.ToString() == p.Name);
    }
}

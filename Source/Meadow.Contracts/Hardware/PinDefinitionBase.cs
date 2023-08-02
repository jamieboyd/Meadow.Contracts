namespace Meadow;

using Meadow.Hardware;
using System.Collections;
using System.Collections.Generic;

public abstract class PinDefinitionBase : IPinDefinitions
{
    private List<IPin> _pins = new();

    public IList<IPin> AllPins => _pins;

    public IPinController Controller { get; set; }

    public IEnumerator<IPin> GetEnumerator() => _pins.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}


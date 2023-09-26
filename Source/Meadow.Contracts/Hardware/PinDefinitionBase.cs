using Meadow.Hardware;
using System.Collections;
using System.Collections.Generic;

namespace Meadow;

/// <summary>
/// Provides a base implementation for device pin lists.
/// </summary>
public abstract class PinDefinitionBase : IPinDefinitions
{
    private List<IPin> _pins = new();
    /// <inheritdoc/>
    public IList<IPin> AllPins => _pins;

    /// <inheritdoc/>
    public IPinController Controller { get; set; }

    /// <inheritdoc/>
    public IEnumerator<IPin> GetEnumerator() => _pins.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}


namespace Meadow.Hardware;

/// <summary>
/// Represents a group of named pins.
/// </summary>
public class NamedPinGroup
{
    /// <summary>
    /// Gets the name of the pin group.
    /// </summary>
    public string Name { get; protected set; }

    /// <summary>
    /// Gets the array of pins in the group.
    /// </summary>
    public IPin[] Pins { get; protected set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedPinGroup"/> class.
    /// </summary>
    /// <param name="name">The name of the pin group.</param>
    /// <param name="pins">The array of pins in the group.</param>
    public NamedPinGroup(string name, IPin[] pins)
    {
        this.Name = name;
        this.Pins = pins;
    }

    /// <summary>
    /// Returns the Name of the <see cref="NamedPinGroup"/> object.
    /// </summary>
    /// <returns>The Name of the <see cref="NamedPinGroup"/> object.</returns>
    public override string ToString() => Name;

    /// <summary>
    /// Implicitly converts a <see cref="NamedPinGroup"/> to an array of pins.
    /// </summary>
    /// <param name="namedPinGroup">The named pin group to convert.</param>
    /// <returns>An array of pins.</returns>
    public static implicit operator IPin[](NamedPinGroup namedPinGroup) => namedPinGroup.Pins;
}

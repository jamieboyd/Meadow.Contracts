using Meadow.Units;

namespace Meadow;

/// <summary>
/// Information about available storage devices
/// </summary>
public interface IStorageInformation
{
    /// <summary>
    /// The store name
    /// </summary>
    public string Name { get; }
    /// <summary>
    /// The space available in the store
    /// </summary>
    public DigitalStorage SpaceAvailable { get; }
    /// <summary>
    /// The total size of the store
    /// </summary>
    public DigitalStorage Size { get; }
}

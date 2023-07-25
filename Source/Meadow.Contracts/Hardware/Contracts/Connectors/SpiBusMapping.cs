namespace Meadow.Hardware;

/// <summary>
/// Represents a mapping of a specific SPI bus on a controller
/// </summary>
public sealed class SpiBusMapping
{
    /// <summary>
    /// Creates a SpiBusMapping
    /// </summary>
    /// <param name="controller">The ISpiController</param>
    /// <param name="clock">The clock pin</param>
    /// <param name="copi">The COPI pin</param>
    /// <param name="cipo">The CIPO pin</param>
    public SpiBusMapping(ISpiController controller, IPin clock, IPin copi, IPin cipo)
    {
        Controller = controller;
        Clock = clock;
        Copi = copi;
        Cipo = cipo;
    }

    /// <summary>
    /// The mapping ISpiController
    /// </summary>
    public ISpiController Controller { get; }
    /// <summary>
    /// The mapping Clock pin
    /// </summary>
    public IPin Clock { get; }
    /// <summary>
    /// The mapping COPI pin
    /// </summary>
    public IPin Copi { get; }
    /// <summary>
    /// The mapping CIPO pin
    /// </summary>
    public IPin Cipo { get; }

}

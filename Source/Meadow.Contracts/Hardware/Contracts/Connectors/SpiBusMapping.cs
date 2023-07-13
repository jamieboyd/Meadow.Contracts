namespace Meadow;

using Meadow.Hardware;

public sealed class SpiBusMapping
{
    public SpiBusMapping(ISpiController controller, IPin clock, IPin copi, IPin cipo)
    {
        Controller = controller;
        Clock = clock;
        Copi = copi;
        Cipo = cipo;
    }

    public ISpiController Controller { get; }
    public IPin Clock { get; }
    public IPin Copi { get; }
    public IPin Cipo { get; }

}

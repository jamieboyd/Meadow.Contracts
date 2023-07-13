namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices capable of creating `ICounter` instances.
    /// </summary>
    public interface ICounterController : IPinController
    {
        /// <summary>
        /// Creates an `ICounter` instance on the specified pin with the specified interrupt edge mode.
        /// </summary>
        /// <param name="pin">The pin to create the counter on.</param>
        /// <param name="edge">The interrupt edge mode for the counter.</param>
        /// <returns>The created counter instance.</returns>
        public ICounter CreateCounter(
            IPin pin,
            InterruptMode edge);
    }
}

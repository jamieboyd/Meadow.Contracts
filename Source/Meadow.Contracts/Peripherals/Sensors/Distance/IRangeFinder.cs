using Meadow.Units;
using System;

namespace Meadow.Peripherals.Sensors.Distance
{
    /// <summary>
    /// Interface for distance sensors classes.
    /// </summary>
    public interface IRangeFinder : ISamplingSensor<Length>
    {
        /// <summary>
        /// Sends a trigger signal
        /// </summary>
        void MeasureDistance();

        /// <summary>
        /// Last value read from the sensor
        /// </summary>
        Length? Distance { get; }

        /// <summary>
        /// Raised when a new reading has been made. Events will only be raised
        /// while the driver is updating. To start, call the `StartUpdating()`
        /// method.
        /// </summary>
        event EventHandler<IChangeResult<Length>> DistanceUpdated;
    }
}
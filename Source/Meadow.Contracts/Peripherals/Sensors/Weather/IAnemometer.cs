using Meadow.Units;
using System;

namespace Meadow.Peripherals.Sensors.Weather
{
    /// <summary>
    /// Represents an anemometer sensor that measures the speed of the wind.
    /// </summary>
    public interface IAnemometer : ISamplingSensor<Speed>
    {
        /// <summary>
        /// Gets the last recorded wind speed.
        /// </summary>
        Speed? WindSpeed { get; }

        /// <summary>
        /// Occurs when the speed of the wind changes.
        /// </summary>
        event EventHandler<IChangeResult<Speed>> WindSpeedUpdated;
    }
}

using System;
using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Weather
{
    public interface IAnemometer : ISamplingSensor<Speed>
    {
        /// <summary>
        /// The last recorded wind speed.
        /// </summary>
        Speed? WindSpeed { get; }

        /// <summary>
        /// Raised when the speed of the wind changes.
        /// </summary>
        event EventHandler<IChangeResult<Speed>> WindSpeedUpdated;
    }
}

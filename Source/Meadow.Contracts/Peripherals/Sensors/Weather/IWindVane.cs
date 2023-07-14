using Meadow.Units;
using System;

namespace Meadow.Peripherals.Sensors.Weather
{
    /// <summary>
    /// Represents a wind vane sensor that measures the azimuth of the wind.
    /// </summary>
    public interface IWindVane : ISamplingSensor<Azimuth>
    {
        /// <summary>
        /// Occurs when the azimuth of the wind changes.
        /// </summary>
        event EventHandler<IChangeResult<Azimuth>> Updated;

        /// <summary>
        /// Gets the last recorded azimuth of the wind.
        /// </summary>
        Azimuth? WindAzimuth { get; }
    }
}
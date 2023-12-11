using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Weather
{
    /// <summary>
    /// Represents a wind vane sensor that measures the azimuth of the wind.
    /// </summary>
    public interface IWindVane : ISamplingSensor<Azimuth>
    {
        /// <summary>
        /// Gets the last recorded azimuth of the wind.
        /// </summary>
        Azimuth? WindAzimuth { get; }
    }
}
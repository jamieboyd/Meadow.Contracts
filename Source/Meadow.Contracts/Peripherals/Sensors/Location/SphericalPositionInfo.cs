namespace Meadow.Peripherals.Sensors.Location
{
    /// <summary>
    /// Represents a position on a globe or sphere, including latitude, longitude, and altitude.
    /// </summary>
    public class SphericalPositionInfo
    {
        /// <summary>
        /// Gets or sets the latitude of the position.
        /// </summary>
        public DegreesMinutesSecondsPosition? Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the position.
        /// </summary>
        public DegreesMinutesSecondsPosition? Longitude { get; set; }

        /// <summary>
        /// Gets or sets the altitude above mean sea level in meters.
        /// </summary>
        public decimal? Altitude { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalPositionInfo"/> class.
        /// </summary>
        public SphericalPositionInfo()
        {
        }
    }
}

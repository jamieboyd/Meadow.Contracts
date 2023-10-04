namespace Meadow.Peripherals.Sensors.Location
{
    // TODO: Should this be a struct with fields?
    /// <summary>
    /// Represents a positional point on a spherical axis.
    /// </summary>
    public class DegreesMinutesSecondsPosition
    {
        /// <summary>
        /// Latitudinal: -90° to 90°
        /// Longitudinal: -180° to 180°
        /// </summary>
        public int Degrees { get; set; }
        /// <summary>
        /// 0' to 60'
        /// </summary>
        public decimal Minutes { get; set; }
        /// <summary>
        /// 0" to 60"
        /// </summary>
        public decimal seconds { get; set; }
        /// <summary>
        /// Cardinal direction.
        /// </summary>
        public CardinalDirection Direction;

        /// <summary>
        /// Returns a string that represents the position in the format dd° mm' ss"X, where X represents the cardinal direction of the position.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            var position = $"{this.Degrees:f2}° {this.Minutes:f2}' {this.seconds:f2}\"";
            switch (this.Direction)
            {
                case CardinalDirection.East:
                    position += "E";
                    break;
                case CardinalDirection.West:
                    position += "W";
                    break;
                case CardinalDirection.North:
                    position += "N";
                    break;
                case CardinalDirection.South:
                    position += "S";
                    break;
                case CardinalDirection.Unknown:
                    position += "Unknown";
                    break;
            }
            return position;

        }
    }
}

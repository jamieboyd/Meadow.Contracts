using System.Text;

namespace Meadow.Peripherals.Sensors.Location.Gnss;

/// <summary>
/// Represents information about a satellite to be used in the GSV (Satellites in View) decoder.
/// </summary>
public class Satellite
{
    /// <summary>
    /// Gets or sets the satellite ID.
    /// </summary>
    public int ID { get; set; }

    /// <summary>
    /// Gets or sets the angle of elevation.
    /// </summary>
    public int Elevation { get; set; }

    /// <summary>
    /// Gets or sets the satellite azimuth.
    /// </summary>
    public int Azimuth { get; set; }

    /// <summary>
    /// Gets or sets the signal to noise ratio of the signal.
    /// </summary>
    public int SignalTolNoiseRatio { get; set; }

    /// <summary>
    /// Returns a string representation of the Satellite object.
    /// </summary>
    /// <returns>A string representation of the Satellite object.</returns>
    public override string ToString()
    {
        StringBuilder outString = new StringBuilder();

        outString.Append($"ID: {ID}, Azimuth: {Azimuth}, Elevation: {Elevation}, Signal to Noise Ratio: {SignalTolNoiseRatio}");

        return outString.ToString();
    }
}
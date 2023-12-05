using Meadow.Units;

namespace Meadow.Peripherals.Sensors.Light
{
    /// <summary>
    /// Light sensor interface requirements.
    /// </summary>
    public interface ILightSensor : ISamplingSensor<Illuminance>
    {
        /// <summary>
        /// Last value read from the Light sensor.
        /// </summary>
        Illuminance? Illuminance { get; }
    }
}
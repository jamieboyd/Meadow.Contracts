using Meadow.Units;

namespace Meadow.Peripherals.Sensors
{
    /// <summary>
    /// Temperature sensor interface requirements.
    /// </summary>
    public interface ITemperatureSensor : ISamplingSensor<Temperature>
    {
        /// <summary>
        /// Last value read from the Temperature sensor.
        /// </summary>
        public Temperature? Temperature { get; }
    }
}
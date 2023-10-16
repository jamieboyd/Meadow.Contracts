namespace Meadow.Peripherals.Sensors
{
    /// <summary>
    /// Represents a sensor service interface for registering sensors.
    /// </summary>
    public interface ISensorService
    {
        /// <summary>
        /// Registers a sampling sensor with the sensor service.
        /// </summary>
        /// <param name="sensor">The sampling sensor to register.</param>
        void RegisterSensor(ISamplingSensor sensor);
    }
}
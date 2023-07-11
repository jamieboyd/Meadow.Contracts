using System;

namespace Meadow.Peripherals.Sensors.Moisture
{
    /// <summary>
    /// Represents a moisture sensor that measures the moisture level.
    /// </summary>
    public interface IMoistureSensor : ISamplingSensor<double>
    {
        /// <summary>
        /// Gets the last value read from the moisture sensor.
        /// </summary>
        double? Moisture { get; }

        /// <summary>
        /// Occurs when a new sensor reading has been made. To enable, call StartSampling().
        /// </summary>
        event EventHandler<IChangeResult<double>> HumidityUpdated;
    }
}
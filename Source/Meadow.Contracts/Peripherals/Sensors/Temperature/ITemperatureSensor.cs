using System;
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

        /// <summary>
        /// Raised when a new reading has been made. Events will only be raised
        /// while the driver is updating. To start, call the `StartUpdating()`
        /// method.
        /// </summary>

        public event EventHandler<IChangeResult<Temperature>> TemperatureUpdated;
    }
}
using System;

namespace Meadow.Peripherals.Sensors.Mass
{
    /// <summary>
    /// Mass sensor interface requirements.
    /// </summary>
    public interface IMassSensor : ISamplingSensor<Units.Mass>
    {
        /// <summary>
        /// Last value read from the sensor.
        /// </summary>
        Units.Mass? Mass { get; }
        /// <summary>
        /// Raised when a new reading has been made. Events will only be raised
        /// while the driver is updating. To start, call the `StartUpdating()`
        /// method.
        /// </summary>
        event EventHandler<IChangeResult<Units.Mass>> MassUpdated;
    }
}
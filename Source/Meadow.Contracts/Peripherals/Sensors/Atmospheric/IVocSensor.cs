using Meadow.Units;
using System;

namespace Meadow.Peripherals.Sensors.Atmospheric
{
    /// <summary>
    /// Volatile Organic Compound (VOC) sensor interface requirements.
    /// </summary>
    public interface IVocSensor : ISamplingSensor<Concentration>
    {
        /// <summary>
        /// Last value read from the VOC sensor.
        /// </summary>
        Concentration? Voc { get; }

        /// <summary>
        /// Raised when a new reading has been made. Events will only be raised
        /// while the driver is updating. To start, call the `StartUpdating()`
        /// method.
        /// </summary>
        event EventHandler<ChangeResult<Concentration>> VocUpdated;
    }
}
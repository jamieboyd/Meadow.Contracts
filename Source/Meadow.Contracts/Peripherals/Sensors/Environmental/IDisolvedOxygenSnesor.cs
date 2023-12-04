using System;

namespace Meadow.Peripherals.Sensors.Environmental
{
    /// <summary>
    /// Disolved Oxygen interface requirements.
    /// </summary>
    public interface IDisolvedOxygenSnesor : ISamplingSensor<double>
    {
        /// <summary>
        /// Last value read from the Disolved Oxygen Saturation sensor.
        /// </summary>
        double? Saturation { get; }

        /// <summary>
        /// Raised when a change in Saturation is detected.
        /// </summary>
        event EventHandler<IChangeResult<double>> SaturationUpdated;
    }
}
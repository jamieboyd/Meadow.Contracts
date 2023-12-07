using System;

namespace Meadow.Peripherals.Sensors.Environmental
{
    /// <summary>
    /// Dissolved Oxygen interface requirements
    /// </summary>
    public interface IDissolvedOxygenSensor : ISamplingSensor<double>
    {
        /// <summary>
        /// Last value read from the Dissolved Oxygen Saturation sensor
        /// </summary>
        double? Saturation { get; }

        /// <summary>
        /// Raised when a change in Saturation is detected
        /// </summary>
        event EventHandler<IChangeResult<double>> SaturationUpdated;
    }
}
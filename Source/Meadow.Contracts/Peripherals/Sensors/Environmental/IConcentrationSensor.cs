using Meadow.Units;
using System;

namespace Meadow.Peripherals.Sensors.Environmental
{
    /// <summary>
    /// Concentration interface requirements.
    /// </summary>
    public interface IConcentrationSensor : ISamplingSensor<Concentration>
    {
        /// <summary>
        /// Last value read from the Concentration sensor.
        /// </summary>
        Concentration? Concentration { get; }

        /// <summary>
        /// Raised when a change in concentration is detected.
        /// </summary>
        event EventHandler<IChangeResult<Concentration>> ConcentrationUpdated;
    }
}
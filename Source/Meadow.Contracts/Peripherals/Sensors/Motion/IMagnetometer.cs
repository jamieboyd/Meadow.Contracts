using Meadow.Units;
using System;

namespace Meadow.Peripherals.Sensors.Motion
{
    /// <summary>
    /// Represents a generic magnetometer sensor that measures the strength and direction of a magnetic field
    /// </summary>
    public interface IMagnetometer : ISamplingSensor<MagneticField3D>
    {
        /// <summary>
        /// Last value read from the sensor
        /// </summary>
        MagneticField3D? MagneticField3D { get; }

        /// <summary>
        /// Raised when a new reading has been made
        /// </summary>
        event EventHandler<IChangeResult<MagneticField3D>> MagneticField3DUpdated;
    }
}
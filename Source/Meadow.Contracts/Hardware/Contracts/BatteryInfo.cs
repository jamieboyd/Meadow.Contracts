using Meadow.Units;
using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Represents battery information.
    /// </summary>
    public class BatteryInfo
    {
        /// <summary>
        /// Gets or sets the temperature of the battery.
        /// </summary>
        public Temperature? Temperature { get; set; }

        /// <summary>
        /// Gets or sets the voltage of the battery.
        /// </summary>
        public Voltage? Voltage { get; set; }

        /// <summary>
        /// Gets or sets the current flowing in or out of the battery.
        /// </summary>
        public Current? Current { get; set; }

        /// <summary>
        /// Gets or sets the mean current flowing in or out of the battery.
        /// </summary>
        public Current? MeanCurrent { get; set; }

        /// <summary>
        /// Gets or sets the state of charge (SOC) of the battery.
        /// </summary>
        public int StateOfCharge { get; set; }

        /// <summary>
        /// Gets or sets the estimated time remaining for the battery to be empty.
        /// </summary>
        public TimeSpan? TimeToEmpty { get; set; }

        /// <summary>
        /// Gets or sets the estimated time remaining for the battery to be fully charged.
        /// </summary>
        public TimeSpan? TimeToFull { get; set; }
    }
}

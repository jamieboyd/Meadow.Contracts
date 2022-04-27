using Meadow.Units;
using System;

namespace Meadow.Hardware
{
    public class BatteryInfo
    {
        public Temperature? Temperature { get; set; }
        public Voltage? Voltage { get; set; }
        public Current? Current { get; set; }
        public Current? MeanCurrent { get; set; }
        public int StateOfCharge { get; set; }
        public TimeSpan? TimeToEmpty { get; set; }
        public TimeSpan? TimeToFull { get; set; }
    }
}

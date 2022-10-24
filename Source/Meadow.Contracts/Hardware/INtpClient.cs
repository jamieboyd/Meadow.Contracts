using System;

namespace Meadow
{
    public delegate void TimeChangedEventHandler(DateTime utcTime);

    /// <summary>
    /// Interface for a Network Time Protocol object
    /// </summary>
    public interface INtpClient
    {
        event TimeChangedEventHandler TimeChanged;

        bool Enabled { get; }
        TimeSpan PollPeriod { get; set; }
    }
}

using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Represents a change result from a digital port event. Contains a `New`
    /// and an optional `Old` value which will be `null` on the first result
    /// within an event series.
    /// </summary>
    public struct DigitalPortResult : IChangeResult<DigitalState>
    {
        public DigitalState New { get; set; }
        public DigitalState? Old { get; set; }

        /// <summary>
        /// Creates an instance of a DigitialPortResult
        /// </summary>
        /// <param name="newState"></param>
        /// <param name="oldState"></param>
        public DigitalPortResult(DigitalState newState, DigitalState? oldState)
        {
            New = newState;
            Old = oldState;
        }
        /// <summary>
        /// The duration of time in between the time the event or notification
        /// ocurred, and the the time it occurred before.
        /// </summary>
        public TimeSpan? Delta
        {
            get => New.Time - Old?.Time;
        }
    }
}
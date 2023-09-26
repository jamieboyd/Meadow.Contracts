using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Provides data for serial data received events.
    /// </summary>
    public class SerialDataReceivedEventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerialDataReceivedEventArgs"/> event.
        /// </summary>
        /// <param name="eventType">The type of serial data received.</param>
        public SerialDataReceivedEventArgs(SerialDataType eventType)
        {
            EventType = eventType;
        }

        /// <summary>
        /// Describes the type of serial data received, either characters or an end 
        /// of file notification.
        /// </summary>
        public SerialDataType EventType { get; }
    }
}

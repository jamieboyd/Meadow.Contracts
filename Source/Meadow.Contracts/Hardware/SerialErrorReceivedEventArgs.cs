using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Provides data from serial communication errors.
    /// </summary>
    public class SerialErrorReceivedEventArgs
    {
        /// <summary>
        /// The type of error encountered during serial communication.
        /// </summary>
        public SerialErrorType EventType { get; }
    }
}

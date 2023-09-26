using System;

namespace Meadow
{
    /// <summary>
    /// Thrown when a port is attempted to be created on a pin or peripheral 
    /// that is already in use.
    /// </summary>
    public class PortInUseException : Exception
    {
        /// <summary>
        /// Creates an instance of a PortInUseException
        /// </summary>
        public PortInUseException()
        {
        }

        /// <summary>
        /// Creates an instance of a PortInUseException
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public PortInUseException(string message)
            : base(message)
        {
        }
    }
}

using System;

namespace Meadow
{
    /// <summary>
    /// Represents a general network exception.
    /// </summary>
    public class NetworkException : Exception
    {
        /// <summary>
        /// Gets the status code associated with the network exception.
        /// </summary>
        public int StatusCode { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkException"/> class.
        /// </summary>
        public NetworkException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkException"/> class with a specified message and status code.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="statusCode">The status code associated with the network exception.</param>
        public NetworkException(string message, int statusCode)
            : base(message)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkException"/> class with a specified status code.
        /// </summary>
        /// <param name="statusCode">The status code associated with the network exception.</param>
        public NetworkException(int statusCode)
        {
            StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkException"/> class with a specified message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public NetworkException(string message)
            : base(message)
        {
        }
    }

    /// <summary>
    /// Represents an exception indicating that a requested network was not found.
    /// </summary>
    public class NetworkNotFoundException : NetworkException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkNotFoundException"/> class with a specified message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public NetworkNotFoundException(string message)
            : base(message)
        {
        }
    }

    /// <summary>
    /// Represents an exception indicating a network authentication failure.
    /// </summary>
    public class NetworkAuthenticationException : NetworkException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetworkAuthenticationException"/> class with a specified message.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        public NetworkAuthenticationException(string message)
            : base(message)
        {
        }
    }
}
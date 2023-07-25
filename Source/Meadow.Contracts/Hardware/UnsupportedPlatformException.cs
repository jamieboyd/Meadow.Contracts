using Meadow.Hardware;
using System;

namespace Meadow;

/// <summary>
/// Represents an exception that is thrown when an unsupported platform is encountered.
/// </summary>
public class UnsupportedPlatformException : Exception
{
    /// <summary>
    /// Gets the current Meadow platform that caused the exception.
    /// </summary>
    public MeadowPlatform CurrentPlatform { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UnsupportedPlatformException"/> class with the specified current platform and error message.
    /// </summary>
    /// <param name="currentPlatform">The current Meadow platform that caused the exception.</param>
    /// <param name="message">The error message that describes the reason for the exception.</param>
    public UnsupportedPlatformException(MeadowPlatform currentPlatform, string message)
        : base(message)
    {
        CurrentPlatform = currentPlatform;
    }
}

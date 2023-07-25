using System;

namespace Meadow;

/// <summary>
/// A message passed from the Meadow host OS to the Meadow stack during startup
/// </summary>
public record PlatformOsMessage
{
    /// <summary>
    /// A prioritization for the message
    /// </summary>
    public MessagePriority Priority { get; set; }
    /// <summary>
    /// The timestamp when the message was generated.
    /// </summary>
    /// <remarks>
    /// Depending on the host OS's ability to retrieve a valid time, this timestamp may only be a "time since boot"
    /// </remarks>
    public DateTime Timestamp { get; set; }
    /// <summary>
    /// The message being passed from the host OS
    /// </summary>
    public string Message { get; set; } = default!;
}

using System;

namespace Meadow.Cloud;

/// <summary>
/// A log message sent to Meadow.Cloud
/// </summary>
public class CloudLog
{
    /// <summary>
    /// The message's Log Level
    /// </summary>
    public string Level { get; set; } = default!;
    /// <summary>
    /// The message's text
    /// </summary>
    public string Message { get; set; } = default!;
    /// <summary>
    /// The timestamp of the message
    /// </summary>
    public DateTime Timestamp { get; set; } = default!;
}
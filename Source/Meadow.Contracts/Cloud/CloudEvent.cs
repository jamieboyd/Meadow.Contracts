using System;
using System.Collections.Generic;

namespace Meadow.Cloud;

/// <summary>
/// An event message set to Meadow.Cloud
/// </summary>
public class CloudEvent
{
    /// <summary>
    /// Gets or sets the CloudEvent's unique identifier
    /// </summary>
    public int EventId { get; set; } = default!;
    /// <summary>
    /// Gets or sets the CloudEvent's Description
    /// </summary>
    public string Description { get; set; } = default!;
    /// <summary>
    /// Gets or set the list of measurements associated with the CloudEvent
    /// </summary>
    public Dictionary<string, object> Measurements { get; set; } = default!;
    /// <summary>
    /// Gets or set the UTC timestamp when the CloudEvent was generated
    /// </summary>
    public DateTimeOffset Timestamp { get; set; } = default!;
}
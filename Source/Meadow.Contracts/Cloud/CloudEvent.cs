using System;
using System.Collections.Generic;

namespace Meadow.Cloud;

public class CloudEvent
{
    public int EventId { get; set; }
    public string Description { get; set; }
    public Dictionary<string, object> Measurements { get; set; }
    public DateTime Timestamp { get; set; }
}
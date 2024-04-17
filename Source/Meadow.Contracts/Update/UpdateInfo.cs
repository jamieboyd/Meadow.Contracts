using System;

namespace Meadow.Update;

/// <summary>
/// Represents information about a specific Meadow Update package
/// </summary>
public class UpdateInfo
{
    /// <summary>
    /// Date and time when the update was published
    /// </summary>
    public DateTime PublishedOn { get; set; }
    /// <summary>
    /// A unique identifier for the Update
    /// </summary>
    public string ID { get; protected set; } = default!;
    /// <summary>
    /// Metadata for the package
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The type of the Update
    /// </summary>
    public UpdateType UpdateType { get; set; }
    /// <summary>
    /// Version information for the Update
    /// </summary>
    public string Version { get; set; } = string.Empty;
    /// <summary>
    /// Download progress (in Bytes) of the Update
    /// </summary>
    public long DownloadProgress { get; set; }
    /// <summary>
    /// The size, in bytes, of the Update
    /// </summary>
    public long FileSize { get; set; }
    /// <summary>
    /// An optional, human-readable summary of the Update
    /// </summary>
    public string? Summary { get; set; }
    /// <summary>
    /// An optional, human-readable detail of the Update
    /// </summary>
    public string? Detail { get; set; }
    /// <summary>
    /// Indicates if the Update has been retrieved
    /// </summary>
    public bool Retrieved { get; set; }
    /// <summary>
    /// Indicates if the Update has been applied
    /// </summary>
    public bool Applied { get; set; }
    /// <summary>
    /// The expected Hash of the Update package
    /// </summary>
    public string Crc { get; set; } = string.Empty;
    /// <summary>
    /// Metadata for the package
    /// </summary>
    public string? Metadata { get; set; }
}
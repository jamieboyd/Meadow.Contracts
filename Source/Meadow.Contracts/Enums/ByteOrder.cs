namespace Meadow;

/// <summary>
/// Describes the byte ordering for multi-byte words.
/// </summary>
public enum ByteOrder
{
    /// <summary>
    /// Little-endian byte ordering, in which bytes are handled from the lowest to the highest
    /// </summary>
    LittleEndian,
    /// <summary>
    /// Big-endian byte ordering, in which bytes are handled from the highest to the lowest
    /// </summary>
    BigEndian
};

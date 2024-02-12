using System;

namespace Meadow.Hardware;

/// <summary>
/// Represents a generic CAN frame.
/// </summary>
public class CanFrame
{
    /// <summary>
    /// Initializes a new instance of the CanFrame class.
    /// </summary>
    public CanFrame(uint id, byte[] data)
        : this(id, data, 0, data.Length)
    {
        ID = id;
    }

    /// <summary>
    /// Initializes a new instance of the CanFrame class.
    /// </summary>
    public CanFrame(uint id, byte[] data, int offset, int length)
    {
        ID = id;
        Data = new byte[length];
        Array.Copy(data, offset, Data, 0, length);
    }

    /// <summary>
    /// Initializes a new instance of the CanFrame class with the specified CanFrame.
    /// </summary>
    /// <param name="other">The CanFrame to use for initialization.</param>
    protected CanFrame(CanFrame other)
    {
        ID = other.ID;
        Data = other.Data;
    }

    /// <summary>
    /// Gets or sets the ID of the CAN frame.
    /// </summary>
    public uint ID { get; set; }

    /// <summary>
    /// Gets or sets the data of the CAN frame.
    /// </summary>
    public byte[] Data { get; set; }
}

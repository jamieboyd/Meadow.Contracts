namespace Meadow.Hardware;

/// <summary>
/// The source/reason for a device wake event
/// </summary>
public enum WakeSource
{
    /// <summary>
    /// The device has resumed due to an elapsed timer
    /// </summary>
    Timer,
    /// <summary>
    /// The device has resumed due to an interrupt
    /// </summary>
    Interrupt
}

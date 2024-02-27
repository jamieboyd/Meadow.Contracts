namespace Meadow.Hardware;

/// <summary>
/// The source/reason for a device wake event
/// </summary>
public enum WakeSource
{
    /// <summary>
    /// The reason for wake in undetermined.
    /// </summary>
    /// <remarks>
    /// This is typically only returned when the device has never been in sleep mode
    /// </remarks>
    Unknown = 0,
    /// <summary>
    /// The device has resumed due to an elapsed timer
    /// </summary>
    Timer = 1,
    /// <summary>
    /// The device has resumed due to an interrupt
    /// </summary>
    Interrupt = 2
}

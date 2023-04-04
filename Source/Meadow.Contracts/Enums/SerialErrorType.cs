namespace Meadow.Hardware;

/// <summary>
/// Describes the type of error encountered during serial communication.
/// </summary>
public enum SerialErrorType
{
    /// <summary>
    /// Transmit buffer is full
    /// </summary>
    TxFull = 0,
    /// <summary>
    /// Receive buffer overrun
    /// </summary>
    RxOverrun = 1,
    /// <summary>
    /// Buffer overrun
    /// </summary>
    Overrun = 2,
    /// <summary>
    /// Parity error on received data
    /// </summary>
    RxParity = 3,
    /// <summary>
    /// Frame error
    /// </summary>
    Frame = 4
}

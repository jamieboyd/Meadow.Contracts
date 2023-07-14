namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices that provide serial communication capabilities.
    /// </summary>
    public interface ISerialController
    {
        /// <summary>
        /// Initializes a new instance of an `ISerialPort`.
        /// When parsing text data, we recommend using the more modern, thread-safe `ISerialMessagePort`.
        /// </summary>
        /// <param name="portName">The `SerialPortName` of the port to use.</param>
        /// <param name="baudRate">The speed, in bits per second, of the serial port.</param>
        /// <param name="parity">The `Parity` enum describing what type of cyclic-redundancy-check (CRC) bit, if any, should be expected in the serial message frame. Default is `Parity.None`.</param>
        /// <param name="dataBits">The number of data bits expected in the serial message frame. Default is 8.</param>
        /// <param name="stopBits">The `StopBits` describing how many bits should be expected at the end of every character in the serial message frame. Default is `StopBits.One`.</param>
        /// <param name="readBufferSize">The size, in bytes, of the read buffer. Default is 1024.</param>
        /// <returns>The created serial port.</returns>
        ISerialPort CreateSerialPort(
            SerialPortName portName,
            int baudRate = 9600,
            int dataBits = 8,
            Parity parity = Parity.None,
            StopBits stopBits = StopBits.One,
            int readBufferSize = 1024);
    }
}
namespace Meadow.Hardware
{
    /// <summary>
    /// Extension methods for the SerialPortName class
    /// </summary>
    public static class SerialPortNameExtensions
    {
        /// <summary>
        /// Creates an ISerialPort directly from a SerialPortName using the current IMeadowDevice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="parity"></param>
        /// <param name="stopBits"></param>
        /// <param name="readBufferSize"></param>
        /// <returns></returns>
        public static ISerialPort CreateSerialPort(
            this SerialPortName name,
            int baudRate = 9600,
            int dataBits = 8,
            Parity parity = Parity.None,
            StopBits stopBits = StopBits.One,
            int readBufferSize = 1024)
        {
            return Resolver.Device.CreateSerialPort(name, baudRate, dataBits, parity, stopBits, readBufferSize);
        }

        /// <summary>
        /// Creates an ISerialMessagePort directly from a SerialPortName using the current IMeadowDevice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="suffixDelimiter"></param>
        /// <param name="preserveDelimiter"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="parity"></param>
        /// <param name="stopBits"></param>
        /// <param name="readBufferSize"></param>
        /// <returns></returns>
        public static ISerialMessagePort CreateSerialMessagePort(
            this SerialPortName name,
            byte[] suffixDelimiter,
            bool preserveDelimiter,
            int baudRate = 9600,
            int dataBits = 8,
            Parity parity = Parity.None,
            StopBits stopBits = StopBits.One,
            int readBufferSize = 512)
        {
            return Resolver.Device.CreateSerialMessagePort(name, suffixDelimiter, preserveDelimiter, baudRate, dataBits, parity, stopBits, readBufferSize);
        }

        /// <summary>
        /// Creates an ISerialMessagePort directly from a SerialPortName using the current IMeadowDevice
        /// </summary>
        /// <param name="name"></param>
        /// <param name="prefixDelimiter"></param>
        /// <param name="preserveDelimiter"></param>
        /// <param name="messageLength"></param>
        /// <param name="baudRate"></param>
        /// <param name="dataBits"></param>
        /// <param name="parity"></param>
        /// <param name="stopBits"></param>
        /// <param name="readBufferSize"></param>
        /// <returns></returns>
        public static ISerialMessagePort CreateSerialMessagePort(
            this SerialPortName name,
            byte[] prefixDelimiter,
            bool preserveDelimiter,
            int messageLength,
            int baudRate = 9600,
            int dataBits = 8,
            Parity parity = Parity.None,
            StopBits stopBits = StopBits.One,
            int readBufferSize = 512)
        {
            return Resolver.Device.CreateSerialMessagePort(name, prefixDelimiter, preserveDelimiter, messageLength, baudRate, dataBits, parity, stopBits, readBufferSize);
        }
    }
}

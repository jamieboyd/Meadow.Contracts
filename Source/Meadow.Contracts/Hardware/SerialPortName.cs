namespace Meadow.Hardware
{
    /// <summary>
    /// Represents the name of a serial port, which consists of both a "friendly" and a system name
    /// </summary>
    public class SerialPortName
    {
        /// <summary>
        /// The common name used for the port in documentation
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The assigned driver name for the port
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// Creates a SerialPortName with the given SystemName
        /// </summary>
        /// <param name="systemName"></param>
        /// <returns></returns>
        public static SerialPortName Create(string systemName)
        {
            return new SerialPortName("manually created", systemName);
        }

        /// <summary>
        /// Creates a SerialPortName with the given FriendlyName and SystemName
        /// </summary>
        /// <param name="systemName"></param>
        /// <param name="friendlyName"></param>
        /// <returns></returns>
        public SerialPortName(string friendlyName, string systemName)
        {
            this.FriendlyName = friendlyName;
            this.SystemName = systemName;
        }
    }
}

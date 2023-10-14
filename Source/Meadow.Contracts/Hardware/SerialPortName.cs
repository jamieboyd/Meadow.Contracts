namespace Meadow.Hardware
{
    /// <summary>
    /// Represents the name of a serial port, which consists of both a "friendly" and a system name
    /// </summary>
    public class SerialPortName
    {
        /// <summary>
        /// The SerialController in documentation
        /// </summary>
        public ISerialController? SerialController { get; private set; }

        /// <summary>
        /// The SerialMessageController in documentation
        /// </summary>
        public ISerialMessageController? SerialMessageController { get; private set; }

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
        /// <param name="systemName">The port's system name</param>
        /// <param name="controller">The port's hardware controller</param>
        public static SerialPortName Create(string systemName, object controller)
        {
            return new SerialPortName("manually created", systemName, controller);
        }

        /// <summary>
        /// Creates a SerialPortName with the given FriendlyName and SystemName
        /// </summary>
        /// <param name="systemName">The port's system name</param>
        /// <param name="friendlyName">The port's user-friendly name</param>
        /// <param name="controller">The port's hardware controller</param>
        public SerialPortName(string friendlyName, string systemName, object controller)
        {
            this.FriendlyName = friendlyName;
            this.SystemName = systemName;

            if (controller is ISerialController sc)
            {
                this.SerialController = sc;
            }
            if (controller is ISerialMessageController smc)
            {
                this.SerialMessageController = smc;
            }
        }
    }
}

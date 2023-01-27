using Meadow.Hardware;
using Meadow.Units;
using System.Linq;

namespace Meadow
{
    /// <summary>
    /// Provides an abstraction for OS services such as configuration so that
    /// Meadow can operate on different OS's and platforms.
    /// </summary>
    public partial interface IPlatformOS : IPowerController
    {
        /// <summary>
        /// Initializes platform-specific OS features
        /// </summary>
        /// <param name="capabilities"></param>
        void Initialize(DeviceCapabilities capabilities);

        /// <summary>
        /// Gets the current CPU temperature
        /// </summary>
        /// <returns></returns>
        Temperature GetCpuTemperature();

        /// <summary>
        /// Gets the OS INtpClient instance
        /// </summary>
        public INtpClient NtpClient { get; }

        /// <summary>
        /// Gets a list of currently available serial ports
        /// </summary>
        /// <returns></returns>
        public SerialPortName[] GetSerialPortNames();

        /// <summary>
        /// Finds a plautform serial port name by either friendly or system name
        /// </summary>
        /// <param name="portName"></param>
        /// <returns></returns>
        public SerialPortName? GetSerialPortName(string portName)
        {
            return GetSerialPortNames().FirstOrDefault(
                p => string.Compare(p.FriendlyName, "portName", true) == 0
                 || string.Compare(p.SystemName, portName, true) == 0);
        }
    }
}

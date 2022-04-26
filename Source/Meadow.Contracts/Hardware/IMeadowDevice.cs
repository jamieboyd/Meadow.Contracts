using Meadow.Hardware;
using Meadow.Units;
using System;
using System.Threading;

namespace Meadow.Devices
{
    /// <summary>
    /// Contract for Meadow boards.
    /// </summary>
    public interface IMeadowDevice :
        IDigitalInputOutputController,
        IBiDirectionalController,
        IAnalogInputController,
        IPwmOutputController,
        ISerialController,
        ISerialMessageController,
        ISpiController,
        II2cController,
        IWatchdogController
    {
        IPin GetPin(string name);

        IPlatformOS PlatformOS { get; }
        
        IDeviceInformation Information { get; }

        /// <summary>
        /// Gets the device capabilities.
        /// </summary>
        DeviceCapabilities Capabilities { get; }

        /// <summary>
        /// Sets the device time
        /// </summary>
        /// <param name="dateTime"></param>
        // TODO: move this to PlatformOS, exposed via MeadowOS
        void SetClock(DateTime dateTime);

        void Initialize();

        void Reset();

        /// <summary>
        /// Put the device into low-power (sleep) mode for the specified amount of time, or until a wake interrupt occurs.
        /// </summary>
        /// <remarks>Use a time of &lt; 0 to only wake on interrupt</remarks>
        /// <param name="seconds"></param>        
        void Sleep(int seconds = Timeout.Infinite);

        BatteryInfo GetBatteryInfo();
        Temperature GetProcessorTemperature();
    }
}

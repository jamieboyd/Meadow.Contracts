using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow
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
        IWatchdogController,
        ICounterController,
        INetworkAdapterController
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

        BatteryInfo GetBatteryInfo();
        Temperature GetProcessorTemperature();
    }
}

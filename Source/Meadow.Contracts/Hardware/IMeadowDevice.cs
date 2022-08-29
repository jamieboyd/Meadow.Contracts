using Meadow.Hardware;
using Meadow.Units;
using System;

namespace Meadow
{
    public delegate void PowerTransitionHandler();

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
        event PowerTransitionHandler BeforeReset;
        event PowerTransitionHandler BeforeSleep;
        event PowerTransitionHandler AfterWake;

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
        /// Put the device into low-power (sleep) mode for the specified amount of time.
        /// </summary>
        /// <param name="duration">Amount of time to sleep</param>
        /// <remarks>duration has a resolution of 1 second and must be between 1 and 0xFFFF, inclusive.</remarks>
        void Sleep(TimeSpan duration);

        /// <summary>
        /// Put the device into low-power (sleep) mode until the specified time.
        /// </summary>
        /// <param name="wakeTime">UTC time to wake</param>
        public void Sleep(DateTime wakeTime)
        {
            if (wakeTime.Kind == DateTimeKind.Local)
            {
                throw new ArgumentException("Wake time must be in UTC");
            }

            Sleep(wakeTime - DateTime.UtcNow);
        }

        BatteryInfo GetBatteryInfo();
        Temperature GetProcessorTemperature();
    }
}

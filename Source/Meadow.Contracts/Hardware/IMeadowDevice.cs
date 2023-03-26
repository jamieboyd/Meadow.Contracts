using Meadow.Hardware;

namespace Meadow;

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

    void Initialize();

    BatteryInfo GetBatteryInfo();
}

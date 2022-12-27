using Meadow.Gateways;

namespace Meadow.Hardware
{
    /// <summary>
    /// Wireless adapter interface.
    /// </summary>
    public interface IWirelessNetworkAdapter : INetworkAdapter
    {
        /// <summary>
        /// Current antenna being used on the WiFi adapter.
        /// </summary>
        AntennaType CurrentAntenna { get; }

        /// <summary>
        /// Change the antenna currently in use.
        /// </summary>
        /// <param name="antenna">Antenna to be used.</param>
        /// <param name="persist">Should this property persist through reboot / power cycle?</param>
        void SetAntenna(AntennaType antenna, bool persist = true);
    }
}

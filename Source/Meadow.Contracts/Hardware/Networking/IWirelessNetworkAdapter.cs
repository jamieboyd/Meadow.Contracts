using Meadow.Gateways;

namespace Meadow.Hardware
{
    public interface IWirelessNetworkAdapter : INetworkAdapter
    {
        AntennaType CurrentAntenna { get; }

        void SetAntenna(AntennaType antenna, bool persist = true);
    }
}

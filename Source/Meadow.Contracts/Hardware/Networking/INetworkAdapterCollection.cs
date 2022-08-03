using System.Collections.Generic;

namespace Meadow.Hardware
{
    public interface INetworkAdapterCollection : IEnumerable<INetworkAdapter>
    {
        INetworkAdapter this[int index] { get; }
    }
}

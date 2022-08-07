using System.Collections.Generic;
using System.Linq;

namespace Meadow.Hardware
{
    public interface INetworkAdapterCollection : IEnumerable<INetworkAdapter>
    {
        INetworkAdapter this[int index] { get; }

        public T Primary<T>() where T : INetworkAdapter
        {
            return this.OfType<T>().First();
        }
    }
}

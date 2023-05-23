using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Meadow.Hardware
{
    public interface INetworkAdapterCollection : IEnumerable<INetworkAdapter>
    {
        public int Count => this.Count();

        INetworkAdapter this[int index] { get; }

        /// <summary>
        /// Retrieves the first registered INetworkAdapter matching the requested type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T? Primary<T>() where T : INetworkAdapter
        {
            return this.OfType<T>().FirstOrDefault();
        }

        Task Refresh();
    }
}

using System.Collections.Generic;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for device pin lists.
    /// </summary>
    public interface IPinDefinitions : IEnumerable<IPin>
    {
        /// <summary>
        /// Convenience property which contains all the pins available on the 
        /// device.
        /// </summary>
        /// <value>All the pins.</value>
        IList<IPin> AllPins { get; }

        /// <summary>
        /// Gets or sets the IPinController associated with the IPins
        /// </summary>
        IPinController? Controller { get; set; }
    }
}

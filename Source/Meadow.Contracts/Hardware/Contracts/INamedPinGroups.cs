using System.Collections.Generic;

namespace Meadow.Hardware
{
    /// <summary>
    /// Represents an interface for accessing named pin groups.
    /// </summary>
    public interface INamedPinGroups
    {
        /// <summary>
        /// Gets a list of all named pin groups.
        /// </summary>
        IList<NamedPinGroup> AllGroups { get; }
    }
}

namespace Meadow.Hardware;

using System.Collections.Generic;

/// <summary>
/// Represents a mapping of a connector pin names to a host IPins
/// </summary>
public sealed class PinMapping : List<PinMapping.PinAlias>
{
    /// <summary>
    /// Represent an alias for a single connector pin
    /// </summary>
    public class PinAlias
    {
        /// <summary>
        /// Creates a PinAlias
        /// </summary>
        /// <param name="name">The Connector pin name</param>
        /// <param name="connectsTo">The host IPin it connects to</param>
        public PinAlias(string name, IPin connectsTo)
        {
            PinName = name;
            ConnectsTo = connectsTo;
        }

        /// <summary>
        /// The Connector pin name
        /// </summary>
        public string PinName { get; }
        /// <summary>
        /// The host IPin it connects to
        /// </summary>
        public IPin ConnectsTo { get; }
    }
}

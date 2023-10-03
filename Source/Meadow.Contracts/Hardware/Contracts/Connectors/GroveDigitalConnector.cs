using System;
using static Meadow.Hardware.GroveDigitalConnector;

namespace Meadow.Hardware;
/// <summary>
/// Represents a connector for Seeed Studio Grove for digital devices. See <seealso href="https://wiki.seeedstudio.com/Grove_System/#digital"/>
/// </summary>

public class GroveDigitalConnector : Connector<GroveDigitalPinDefinitions>
{
    /// <summary>
    /// The set of digital Grove connector pins
    /// </summary>
    public static class PinNames
    {
        /// <summary>
        /// Primary Digital Input/Output
        /// </summary>
        public const string D0 = "D0";
        /// <summary>
        /// Secondary Digital Input/Output
        /// </summary>
        public const string D1 = "D1";
    }

    /// <summary>
    /// Represents the pins definitions for the Grove Digital connector
    /// </summary>
    public class GroveDigitalPinDefinitions : PinDefinitionBase
    {
        private readonly IPin? _d0;
        private readonly IPin? _d1;

        /// <summary>
        /// Primary Digital Input/Output
        /// </summary>
        public IPin D0 => _d0 ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Secondary Digital Input/Output
        /// </summary>
        public IPin D1 => _d1 ?? throw new PlatformNotSupportedException("Pin not connected");

        internal GroveDigitalPinDefinitions(PinMapping mapping)
        {
            foreach (var m in mapping)
            {
                switch (m.PinName)
                {
                    case PinNames.D0:
                        _d0 = m.ConnectsTo;
                        break;
                    case PinNames.D1:
                        _d1 = m.ConnectsTo;
                        break;
                }
            }
        }
    }

    /// <param name="name">The connector name</param>
    /// <param name="mapping">The mappings to the host controller</param>
    public GroveDigitalConnector(string name, PinMapping mapping)
        : base(name, new GroveDigitalPinDefinitions(mapping))
    {
    }
}
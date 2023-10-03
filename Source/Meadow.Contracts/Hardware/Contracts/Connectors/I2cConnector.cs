using System;
using static Meadow.Hardware.I2cConnector;

namespace Meadow.Hardware;
/// <summary>
/// Represents a connector for 2 wire I2C devices
/// </summary>
public partial class I2cConnector : Connector<I2cPinDefinitions>
{
    private readonly I2cBusMapping _i2cBusMapping;
    private II2cBus? _i2c;

    /// <summary>
    /// The set of I2C pin names
    /// </summary>
    public static class PinNames
    {
        /// <summary>
        /// I2C Clock Pin (SCL)
        /// </summary>
        public const string SCL = "SCL";
        /// <summary>
        /// I2C Data Pin (SDA)
        /// </summary>
        public const string SDA = "SDA";
    }

    /// <summary>
    /// Represents the pins definitions for the 2 wire I2C connector
    /// </summary>
    public class I2cPinDefinitions : PinDefinitionBase
    {
        private readonly IPin? _scl;
        private readonly IPin? _sda;

        /// <summary>
        /// I2C Clock Pin (SCL)
        /// </summary>
        public IPin Scl => _scl ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// I2C Data Pin (SDA)
        /// </summary>
        public IPin Sda => _sda ?? throw new PlatformNotSupportedException("Pin not connected");

        internal I2cPinDefinitions(PinMapping mapping)
        {
            foreach (var m in mapping)
            {
                switch (m.PinName)
                {
                    case PinNames.SCL:
                        _scl = m.ConnectsTo;
                        break;
                    case PinNames.SDA:
                        _sda = m.ConnectsTo;
                        break;
                }
            }
        }
    }

    /// <summary>
    /// Creates a I2cConnector
    /// </summary>
    /// <param name="name">The connector name</param>
    /// <param name="mapping">The mappings to the host controller</param>
    /// <param name="i2CBusMapping">The mapping for the connector's I2C bus</param>
    public I2cConnector(string name,
        PinMapping mapping,
        I2cBusMapping i2CBusMapping)
        : base(name, new I2cPinDefinitions(mapping))
    {
        _i2cBusMapping = i2CBusMapping;
    }

    /// <summary>
    /// Gets the connector's I2C bus
    /// </summary>
    public II2cBus I2cBus
        => _i2c ??= _i2cBusMapping.Controller.CreateI2cBus(_i2cBusMapping.BusNumber, I2cBusSpeed.Standard);
}
namespace Meadow.Hardware;

using System;
using static Meadow.Hardware.QwiicConnector;

/// <summary>
/// Represents a connector for Qwiic devices
/// </summary>
public partial class QwiicConnector : Connector<QwiicPinDefinitions>
{
    private I2cBusMapping _i2cBusMapping;
    private II2cBus? _i2c;

    /// <summary>
    /// The set of Qwiic pin names
    /// </summary>
    public static class PinNames
    {
        /// <summary>
        /// Pin CIPO
        /// </summary>
        public const string SCL = "SCL";
        /// <summary>
        /// Pin COPI
        /// </summary>
        public const string SDA = "SDA";
    }

    /// <summary>
    /// Represents the pins definitions for the I2C Qwiic connector
    /// </summary>
    public class QwiicPinDefinitions : PinDefinitionBase
    {
        private IPin? _scl;
        private IPin? _sda;

        /// <summary>
        /// Pin SCL
        /// </summary>
        public IPin Scl => _scl ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin TX
        /// </summary>
        public IPin Sda => _sda ?? throw new PlatformNotSupportedException("Pin not connected");

        internal QwiicPinDefinitions(PinMapping mapping)
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
    /// Creates a QwiicConnector
    /// </summary>
    /// <param name="name">The connector name</param>
    /// <param name="mapping">The mappings to the host controller</param>
    /// <param name="i2CBusMapping">The mapping for the connector's I2C bus</param>
    public QwiicConnector(string name,
        PinMapping mapping,
        I2cBusMapping i2CBusMapping)
        : base(name, new QwiicPinDefinitions(mapping))
    {
        _i2cBusMapping = i2CBusMapping;
    }

    /// <summary>
    /// Gets the connector's I2C bus
    /// </summary>
    public II2cBus I2cBus
        => _i2c ??= _i2cBusMapping.Controller.CreateI2cBus(_i2cBusMapping.BusNumber, I2cBusSpeed.Standard);
}
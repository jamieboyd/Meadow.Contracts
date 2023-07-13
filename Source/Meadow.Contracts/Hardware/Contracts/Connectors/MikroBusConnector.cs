namespace Meadow;

using Meadow.Hardware;
using Meadow.Units;
using static Meadow.MikroBusConnector;

/// <summary>
/// Represents a connector for MikroBus devices
/// </summary>
public partial class MikroBusConnector : Connector<MikroBusPinDefinitions>
{
    private SerialPortName _serialPortName;
    private I2cBusMapping _i2cBusMapping;
    private SpiBusMapping _spiBusMapping;

    /// <summary>
    /// The set of MikroBus pin names
    /// </summary>
    public static class PinNames
    {
        /// <summary>
        /// Pin AN
        /// </summary>
        public const string AN = "AN";
        /// <summary>
        /// Pin RST
        /// </summary>
        public const string RST = "RST";
        /// <summary>
        /// Pin CS
        /// </summary>
        public const string CS = "CS";
        /// <summary>
        /// Pin SCK
        /// </summary>
        public const string SCK = "SCK";
        /// <summary>
        /// Pin CIPO
        /// </summary>
        public const string CIPO = "CIPO";
        /// <summary>
        /// Pin COPI
        /// </summary>
        public const string COPI = "COPI";
        /// <summary>
        /// Pin PWM
        /// </summary>
        public const string PWM = "PWM";
        /// <summary>
        /// Pin INT
        /// </summary>
        public const string INT = "INT";
        /// <summary>
        /// Pin RX
        /// </summary>
        public const string RX = "RX";
        /// <summary>
        /// Pin TX
        /// </summary>
        public const string TX = "TX";
        /// <summary>
        /// Pin SCL
        /// </summary>
        public const string SCL = "SCL";
        /// <summary>
        /// Pin SDA
        /// </summary>
        public const string SDA = "SDA";
    }

    /// <summary>
    /// Creates a MikroBusConnector
    /// </summary>
    /// <param name="name">The connector name</param>
    /// <param name="mapping">The mappings to the host controller</param>
    /// <param name="hostSerialPort">The mapping for the connector's serial port</param>
    /// <param name="i2CBusMapping">The mapping for the connector's I2C bus</param>
    /// <param name="spiBusMapping">The mapping for the connector's SPI bus</param>
    public MikroBusConnector(string name,
        PinMapping mapping,
        SerialPortName hostSerialPort,
        I2cBusMapping i2CBusMapping,
        SpiBusMapping spiBusMapping)
        : base(name, new MikroBusPinDefinitions(mapping))
    {
        _serialPortName = hostSerialPort;
        _i2cBusMapping = i2CBusMapping;
        _spiBusMapping = spiBusMapping;
    }

    /// <summary>
    /// Creates a serial port on the connector
    /// </summary>
    /// <param name="baudRate">The speed, in bits per second, of the serial port.</param>
    /// <param name="parity">The `Parity` enum describing what type of cyclic-redundancy-check (CRC) bit, if any, should be expected in the serial message frame. Default is `Parity.None`.</param>
    /// <param name="dataBits">The number of data bits expected in the serial message frame. Default is 8.</param>
    /// <param name="stopBits">The `StopBits` describing how many bits should be expected at the end of every character in the serial message frame. Default is `StopBits.One`.</param>
    /// <param name="readBufferSize">The size, in bytes, of the read buffer. Default is 1024.</param>
    public ISerialPort CreateSerialPort(int baudRate = 9600, int dataBits = 8, Parity parity = Parity.None, StopBits stopBits = StopBits.One, int readBufferSize = 1024)
    {
        return _serialPortName.CreateSerialPort(baudRate, dataBits, parity, stopBits, readBufferSize);
    }

    /// <summary>
    /// Creates an II2cBus on the connector
    /// </summary>
    /// <param name="busSpeed">The bus speed</param>
    public II2cBus CreateI2cBus(I2cBusSpeed busSpeed = I2cBusSpeed.Standard)
    {
        return _i2cBusMapping.Controller.CreateI2cBus(_i2cBusMapping.BusNumber, busSpeed);
    }

    /// <summary>
    /// Creates an ISpiBus on the connector
    /// </summary>
    /// <param name="speed">The bus speed</param>
    public ISpiBus CreateSpiBus(Frequency speed)
    {
        return _spiBusMapping.Controller.CreateSpiBus(_spiBusMapping.Clock, _spiBusMapping.Copi, _spiBusMapping.Cipo, speed);
    }

    /// <summary>
    /// Creates an ISpiBus on the connector
    /// </summary>
    /// <param name="config">The bus clock configuration parameters</param>
    public ISpiBus CreateSpiBus(SpiClockConfiguration config)
    {
        return _spiBusMapping.Controller.CreateSpiBus(_spiBusMapping.Clock, _spiBusMapping.Copi, _spiBusMapping.Cipo, config);
    }
}

namespace Meadow;

using Meadow.Hardware;
using Meadow.Units;
using static Meadow.MikroBusConnector;

public partial class MikroBusConnector : Connector<MikroBusPinDefinitions>
{
    private SerialPortName _serialPortName;
    private I2cBusMapping _i2cBusMapping;
    private SpiBusMapping _spiBusMapping;

    public static class PinNames
    {
        public const string AN = "AN";
        public const string RST = "RST";
        public const string CS = "CS";
        public const string SCK = "SCK";
        public const string CIPO = "CIPO";
        public const string COPI = "COPI";
        public const string PWM = "PWM";
        public const string INT = "INT";
        public const string RX = "RX";
        public const string TX = "TX";
        public const string SCL = "SCL";
        public const string SDA = "SDA";
    }

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

    public ISerialPort CreateSerialPort(int baudRate = 9600, int dataBits = 8, Parity parity = Parity.None, StopBits stopBits = StopBits.One, int readBufferSize = 1024)
    {
        return _serialPortName.CreateSerialPort(baudRate, dataBits, parity, stopBits, readBufferSize);
    }

    public II2cBus CreateI2cBus(I2cBusSpeed busSpeed = I2cBusSpeed.Standard)
    {
        return _i2cBusMapping.Controller.CreateI2cBus(_i2cBusMapping.BusNumber, busSpeed);
    }

    public ISpiBus CreateSpiBus(Frequency speed)
    {
        return _spiBusMapping.Controller.CreateSpiBus(_spiBusMapping.Clock, _spiBusMapping.Copi, _spiBusMapping.Cipo, speed);
    }

    public ISpiBus CreateSpiBus(SpiClockConfiguration config)
    {
        return _spiBusMapping.Controller.CreateSpiBus(_spiBusMapping.Clock, _spiBusMapping.Copi, _spiBusMapping.Cipo, config);
    }
}

using System;
using static Meadow.Hardware.GroveUartConnector;

namespace Meadow.Hardware;

public class GroveUartConnector : Connector<GroveUartPinDefinitions>
{
    private SerialPortName _serialPortName;

    /// <summary>
    /// The set of UART (serial) Grove connector pins
    /// </summary>
    public static class PinNames
    {
        /// <summary>
        /// Pin D0
        /// </summary>
        public const string RX = "RX";
        /// <summary>
        /// Pin D0
        /// </summary>
        public const string TX = "TX";
    }

    /// <summary>
    /// Represents the pins definitions for the Grove Uart (serial) connector
    /// </summary>
    public class GroveUartPinDefinitions : PinDefinitionBase
    {
        private IPin? _rx;
        private IPin? _tx;

        /// <summary>
        /// Pin RX
        /// </summary>
        public IPin Rx => _rx ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin TX
        /// </summary>
        public IPin Tx => _tx ?? throw new PlatformNotSupportedException("Pin not connected");

        internal GroveUartPinDefinitions(PinMapping mapping)
        {
            foreach (var m in mapping)
            {
                switch (m.PinName)
                {
                    case PinNames.RX:
                        _rx = m.ConnectsTo;
                        break;
                    case PinNames.TX:
                        _tx = m.ConnectsTo;
                        break;
                }
            }
        }
    }

    /// <param name="name">The connector name</param>
    /// <param name="mapping">The mappings to the host controller</param>
    public GroveUartConnector(string name, PinMapping mapping, SerialPortName hostSerialPort)
        : base(name, new GroveUartPinDefinitions(mapping))
    {
        _serialPortName = hostSerialPort;
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
}
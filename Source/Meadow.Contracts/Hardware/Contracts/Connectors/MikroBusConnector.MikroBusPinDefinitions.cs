using System;

namespace Meadow.Hardware;
public partial class MikroBusConnector
{
    /// <summary>
    /// Represents the pins definitions for the MikroBus connector
    /// </summary>
    public class MikroBusPinDefinitions : PinDefinitionBase
    {
        private readonly IPin? _an;
        private readonly IPin? _rst;
        private readonly IPin? _cs;
        private readonly IPin? _sck;
        private readonly IPin? _cipo;
        private readonly IPin? _copi;
        private readonly IPin? _pwm;
        private readonly IPin? _int;
        private readonly IPin? _rx;
        private readonly IPin? _tx;
        private readonly IPin? _scl;
        private readonly IPin? _sda;

        /// <summary>
        /// Pin AN
        /// </summary>
        public IPin AN => _an ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin RST
        /// </summary>
        public IPin RST => _rst ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin CS
        /// </summary>
        public IPin CS => _cs ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin SCK
        /// </summary>
        public IPin SCK => _sck ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin CIPO
        /// </summary>
        public IPin CIPO => _cipo ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin COPI
        /// </summary>
        public IPin COPI => _copi ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin PWM
        /// </summary>
        public IPin PWM => _pwm ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin INT
        /// </summary>
        public IPin INT => _int ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin RX
        /// </summary>
        public IPin RX => _rx ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin TX
        /// </summary>
        public IPin TX => _tx ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin SCL
        /// </summary>
        public IPin SCL => _scl ?? throw new PlatformNotSupportedException("Pin not connected");
        /// <summary>
        /// Pin SDA
        /// </summary>
        public IPin SDA => _sda ?? throw new PlatformNotSupportedException("Pin not connected");

        internal MikroBusPinDefinitions(
            PinMapping mapping
            )
        {
            foreach (var m in mapping)
            {
                switch (m.PinName)
                {
                    case PinNames.AN:
                        _an = m.ConnectsTo;
                        break;
                    case PinNames.RST:
                        _rst = m.ConnectsTo;
                        break;
                    case PinNames.CS:
                        _cs = m.ConnectsTo;
                        break;
                    case PinNames.SCK:
                        _sck = m.ConnectsTo;
                        break;
                    case PinNames.CIPO:
                        _cipo = m.ConnectsTo;
                        break;
                    case PinNames.COPI:
                        _copi = m.ConnectsTo;
                        break;
                    case PinNames.PWM:
                        _pwm = m.ConnectsTo;
                        break;
                    case PinNames.INT:
                        _int = m.ConnectsTo;
                        break;
                    case PinNames.RX:
                        _rx = m.ConnectsTo;
                        break;
                    case PinNames.TX:
                        _tx = m.ConnectsTo;
                        break;
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
}

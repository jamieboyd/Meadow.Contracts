namespace Meadow;

using Meadow.Hardware;
using System;

public partial class MikroBusConnector
{
    public class MikroBusPinDefinitions : PinDefinitionBase
    {
        private IPin? _an;
        private IPin? _rst;
        private IPin? _cs;
        private IPin? _sck;
        private IPin? _cipo;
        private IPin? _copi;
        private IPin? _pwm;
        private IPin? _int;
        private IPin? _rx;
        private IPin? _tx;
        private IPin? _scl;
        private IPin? _sda;

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

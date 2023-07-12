namespace Meadow;

using static Meadow.MikroBusConnector;

public partial class MikroBusConnector : Connector<MikroBusPinDefinitions>//, ISerialController
{
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

    public MikroBusConnector(string name, PinMapping mapping)
        : base(name, new MikroBusPinDefinitions(mapping))
    {
    }
}

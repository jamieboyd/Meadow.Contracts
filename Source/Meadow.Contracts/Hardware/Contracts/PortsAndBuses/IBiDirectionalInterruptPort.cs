namespace Meadow.Hardware
{
    public interface IBiDirectionalInterruptPort : IDigitalInterruptPort, IDigitalOutputPort
    {
        PortDirectionType Direction { get; set; }
        public new bool State { get; set; }
    }
}

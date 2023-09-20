namespace Meadow.Hardware
{

    /// <summary>
    /// Contract for BiDirectional Ports; digital ports that can be both input and output.
    /// </summary>
    public interface IBiDirectionalInterruptPort : IDigitalInterruptPort, IDigitalOutputPort
    {
        /// <inheritdoc/>
        PortDirectionType Direction { get; set; }
        /// <inheritdoc/>
        public new bool State { get; set; }
    }
}

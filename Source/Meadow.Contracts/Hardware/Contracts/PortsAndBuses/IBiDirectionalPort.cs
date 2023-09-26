namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for ports that are capable of reading inputs and writing digital outputs.
    /// </summary>
    public interface IBiDirectionalPort : IDigitalInputPort, IDigitalOutputPort
    {
        /// <summary>
        /// Gets or sets the current direction of the port
        /// </summary>
        PortDirectionType Direction { get; set; }
    }
}

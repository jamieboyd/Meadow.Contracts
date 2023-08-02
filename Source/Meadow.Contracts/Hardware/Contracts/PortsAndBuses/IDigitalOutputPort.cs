namespace Meadow.Hardware
{
    /// <summary>
    /// Represents a digital output port.
    /// </summary>
    public interface IDigitalOutputPort : IDigitalPort
    {
        /// <summary>
        /// Gets the initial state of the port, either low (false) or high (true), as typically configured during the port's constructor.
        /// </summary>
        bool InitialState { get; }

        /// <summary>
        /// Gets or sets the state of the port.
        /// </summary>
        /// <value><c>true</c> for HIGH; otherwise, <c>false</c> for LOW.</value>
        bool State { get; set; }
    }
}

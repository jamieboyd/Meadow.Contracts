namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for IO devices that are capable of creating an `IAnalogOutputPort`
    /// instances.
    /// </summary>
    public interface IAnalogOutputController : IPinController
    {
        /// <summary>
        /// Creates an IAnalogOutputPort on the specified pin
        /// </summary>
        /// <param name="pin">The pin on which to create the port.</param>
        public IAnalogOutputPort CreateAnalogOutputPort(IPin pin);
    }
}

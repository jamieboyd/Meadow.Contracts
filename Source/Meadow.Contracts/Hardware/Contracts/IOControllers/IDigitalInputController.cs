namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for IO devices that are capable of creating `IDigitalInputPort`
    /// instances.
    /// </summary>
    public interface IDigitalInputController : IPinController
    {
        /// <summary>
        /// Creates an IDigitalInputPort on the specified pin.
        /// </summary>
        /// <param name="pin">The pin on which to create the port.</param>
        /// <param name="resistorMode">The `ResistorMode` specifying whether an
        /// external pull-up/pull-down resistor is used, or an internal pull-up/pull-down
        /// resistor should be configured for default state.</param>
        IDigitalInputPort CreateDigitalInputPort(
            IPin pin,
            ResistorMode resistorMode
            );

        /// <summary>
        /// Creates an IDigitalInputPort on the specified pin with Disabled resistor mode
        /// </summary>
        /// <param name="pin">The pin on which to create the port.</param>
        /// external pull-up/pull-down resistor is used, or an internal pull-up/pull-down
        /// resistor should be configured for default state.</param>
        public IDigitalInputPort CreateDigitalInputPort(
            IPin pin
            )
        {
            return CreateDigitalInputPort(pin, ResistorMode.Disabled);
        }
    }
}
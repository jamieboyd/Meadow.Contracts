namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices capable of both digital input and output operations.
    /// </summary>
    public interface IDigitalInputOutputController : IDigitalInputController, IDigitalOutputController
    {
    }
}

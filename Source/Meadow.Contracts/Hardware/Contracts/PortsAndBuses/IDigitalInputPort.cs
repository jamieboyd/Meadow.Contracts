namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for ports that are capable of reading digital input and raising
    /// events when state changes.
    /// </summary>
    public interface IDigitalInputPort : IDigitalPort
    {
        bool State { get; }
        ResistorMode Resistor { get; set; }
    }
}
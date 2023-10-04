using System.Threading.Tasks;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for ports that implement an analog output channel.
    /// </summary>
    public interface IAnalogOutputPort : IAnalogPort
    {
        /// <summary>
        /// Instructs the IAnalogOutputPort to generate an analog output signal corresponding to the provided digital value
        /// </summary>
        /// <param name="digitalValue">The digital value to convert to an analog signal</param>
        Task GenerateOutput(uint digitalValue);
    }
}
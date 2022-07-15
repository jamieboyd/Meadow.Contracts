using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices that expose `IBiDirectionPort(s)`.
    /// </summary>
    public interface IBiDirectionalController
    {
        /// <summary>
        /// Creates an `IBiDirectionPort` on the specified pin.
        /// </summary>
        /// <param name="pin"></param>
        /// <param name="initialState"></param>
        /// <param name="interruptMode"></param>
        /// <param name="resistorMode"></param>
        /// <param name="initialDirection"></param>
        /// <param name="debounceDuration"></param>
        /// <param name="glitchDuration"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        IBiDirectionalPort CreateBiDirectionalPort(
            IPin pin,
            bool initialState,
            InterruptMode interruptMode,
            ResistorMode resistorMode,
            PortDirectionType initialDirection,
            TimeSpan debounceDuration,
            TimeSpan glitchDuration,
            OutputType output = OutputType.PushPull
        );

    }
}

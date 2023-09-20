using System;
namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices that expose `IBiDirectionPort(s)`.
    /// </summary>
    public interface IBiDirectionalController : IPinController
    {
        /// <summary>
        /// Creates an `IBiDirectionalInterruptPort` on the specified pin.
        /// </summary>
        /// <param name="pin">The pin on which to create the port.</param>
        /// <param name="initialState"></param>
        /// <param name="interruptMode">An `InterruptMode` describing whether or
        /// not the port should be notify on change, and what type of change to
        /// notify on.</param>
        /// <param name="resistorMode">The `ResistorMode` specifying whether an
        /// external pull-up/pull-down resistor is used, or an internal pull-up/pull-down
        /// resistor should be configured for default state.</param>
        /// <param name="initialDirection"></param>
        /// <param name="debounceDuration">The duration, with microseconds (µs) resolution,
        /// of the time to ignore state changes _after_ a deliberate state change
        /// has occurred. Used to prevent unwanted state changes due to noise.
        /// Set to `0` if no debounce filter is required.</param>
        /// <param name="glitchDuration">The minimum duration, with microseconds
        /// (µs) resolution, of an initial state change to persist before it's notified as
        /// an intentional state change, rather than a spurious one. Use this to
        /// ensure that noise doesn't trigger an in interrupt.</param>
        /// <param name="output"></param>
        /// <returns>an `IBiDirectionalInterruptPort` for the specified pin</returns>
        IBiDirectionalInterruptPort CreateBiDirectionalInterruptPort(
            IPin pin,
            bool initialState,
            InterruptMode interruptMode,
            ResistorMode resistorMode,
            PortDirectionType initialDirection,
            TimeSpan debounceDuration,
            TimeSpan glitchDuration,
            OutputType output = OutputType.PushPull
        );

        /// <summary>
        /// Creates an `IBiDirectionalInterruptPort` on the specified pin.
        /// </summary>
        /// <param name="pin">The pin on which to create the port.</param>
        /// <returns>an `IBiDirectionalInterruptPort` for the specified pin</returns>
        IBiDirectionalInterruptPort CreateBiDirectionalInterruptPort(
            IPin pin)
        {
            return CreateBiDirectionalInterruptPort(pin, false, InterruptMode.None, ResistorMode.Disabled, PortDirectionType.Input, TimeSpan.Zero, TimeSpan.Zero);
        }

        /// <summary>
        /// Creates an `IBiDirectionalInterruptPort` on the specified pin.
        /// </summary>
        /// <param name="pin">The pin on which to create the port.</param>
        /// <param name="initialState"></param>
        /// <returns>an `IBiDirectionalInterruptPort` for the specified pin</returns>
        IBiDirectionalPort CreateBiDirectionalPort(
            IPin pin,
            bool initialState);

    }
}

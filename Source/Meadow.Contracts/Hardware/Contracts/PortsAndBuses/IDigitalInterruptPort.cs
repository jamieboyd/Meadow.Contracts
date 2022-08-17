using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Defines a digital interrupt port
    /// </summary>
    public interface IDigitalInterruptPort
    {
        //TODO: should this be `Updated`?
        /// <summary>
        /// Raised when the digital port state is changed / updated
        /// </summary>
        event EventHandler<DigitalPortResult> Changed;

        /// <summary>
        /// The interrupt mode use to determine when interrupts are raised
        /// </summary>
        InterruptMode InterruptMode { get; }

        /// <summary>
        /// The debouce duration 
        /// Effectively a delay after an event where new inputs are ignored
        /// </summary>
        TimeSpan DebounceDuration { get; set; }

        /// <summary>
        /// The glitch duration 
        /// This is the minimum amount of time a signal needs to be stable before an event is recognized
        /// </summary>
        TimeSpan GlitchDuration { get; set; }
    }
}

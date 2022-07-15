using System;

namespace Meadow.Hardware
{
    public interface IDigitalInterruptPort
    {
        //TODO: should this be `Updated`?
        event EventHandler<DigitalPortResult> Changed;

        InterruptMode InterruptMode { get; }
        TimeSpan DebounceDuration { get; set; }
        TimeSpan GlitchDuration { get; set; }
    }
}

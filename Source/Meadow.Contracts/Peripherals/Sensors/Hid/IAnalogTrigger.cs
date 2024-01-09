using System;

namespace Meadow.Peripherals.Sensors.Hid;

/// <summary>
/// Interface describing a variable button trigger
/// </summary>
public interface IAnalogTrigger
{
    /// <summary>
    /// Position of analog trigger
    /// </summary>
    public double? Position { get; }

    /// <summary>
    /// Raised when a new reading has been made. 
    /// </summary>
    public event EventHandler<ChangeResult<double>> Updated;
}
using Meadow.Units;
using System;

namespace Meadow.Hardware;

/// <summary>
/// Delegate for handling interrupts on a pin.
/// </summary>
/// <param name="pin">The <see cref="IPin"/> that triggered the interrupt.</param>
/// <param name="state">The state of the interrupt (e.g., rising or falling edge).</param>
public delegate void InterruptHandler(IPin pin, bool state);

/// <summary>
/// Defines the GPIO Manager for interacting with digital and analog pins.
/// </summary>
public interface IMeadowIOController
{
    /// <summary>
    /// Event triggered when an interrupt occurs on a pin.
    /// </summary>
    event InterruptHandler Interrupt;

    /// <summary>
    /// Initializes the device pins to their default power-up status (outputs, low, and pulled down where applicable).
    /// </summary>
    /// <param name="reservedPinList">List of any pins to reserve.</param>
    void Initialize(string[]? reservedPinList);

    /// <summary>
    /// Sets the value of a discrete (digital) output pin.
    /// </summary>
    /// <param name="pin">The <see cref="IPin"/> representing the discrete output pin.</param>
    /// <param name="value">The value to set on the discrete output pin (true for high, false for low).</param>
    void SetDiscrete(IPin pin, bool value);

    /// <summary>
    /// Gets the value of a discrete (digital) input pin.
    /// </summary>
    /// <param name="pin">The <see cref="IPin"/> representing the discrete input pin.</param>
    /// <returns>The value of the discrete input pin (true for high, false for low).</returns>
    bool GetDiscrete(IPin pin);

    /// <summary>
    /// Sets the resistor mode for the given pin.
    /// </summary>
    /// <param name="pin">The <see cref="IPin"/> to set the resistor mode for.</param>
    /// <param name="mode">The resistor mode to set.</param>
    void SetResistorMode(IPin pin, ResistorMode mode);

    /// <summary>
    /// Configures a pin as an output with specified initial state and output type.
    /// </summary>
    void ConfigureOutput(
        IPin pin,
        bool initialState,
        OutputType outputType
        );

    /// <summary>
    /// Configures a pin as an input with specified resistor mode, interrupt mode, debounce duration, and glitch duration.
    /// </summary>
    void ConfigureInput(
        IPin pin,
        ResistorMode resistorMode,
        InterruptMode interruptMode,
        TimeSpan debounceDuration,
        TimeSpan glitchDuration
        );

    /// <summary>
    /// Wires an interrupt for the specified pin with the given interrupt mode, resistor mode, debounce duration, and glitch duration.
    /// </summary>
    void WireInterrupt(IPin pin,
        InterruptMode interruptMode,
        ResistorMode resistorMode,
        TimeSpan debounceDuration,
        TimeSpan glitchDuration
        );

    /// <summary>
    /// Unconfigures a previously configured GPIO pin.
    /// </summary>
    /// <param name="pin">The <see cref="IPin"/> to unconfigure.</param>
    /// <returns><c>true</c> if the pin was successfully unconfigured, <c>false</c> otherwise.</returns>
    bool UnconfigureGpio(IPin pin);

    /// <summary>
    /// Configures a pin as an analog input.
    /// </summary>
    void ConfigureAnalogInput(IPin pin);

    /// <summary>
    /// Gets the analog value read from the specified pin.
    /// </summary>
    /// <param name="pin">The <see cref="IPin"/> representing the analog input pin.</param>
    /// <returns>The analog value read from the pin.</returns>
    int GetAnalogValue(IPin pin);

    /// <summary>
    /// Reasserts the configuration for the specified pin.
    /// </summary>
    /// <param name="pin">The <see cref="IPin"/> to reassert the configuration for.</param>
    /// <param name="validateInterruptGroup">Whether to validate the interrupt group for the pin.</param>
    void ReassertConfig(IPin pin, bool validateInterruptGroup = true);

    /// <summary>
    /// Gets the temperature reading from the device.
    /// </summary>
    /// <returns>The current temperature reading as a <see cref="Temperature"/> object.</returns>
    Temperature GetTemperature();

    /// <summary>
    /// Gets the device channel manager for managing input and output channels.
    /// </summary>
    IDeviceChannelManager DeviceChannelManager { get; }
}

namespace Meadow.Hardware;


/// <summary>
/// TODO: revisit this structure. Ultimately, it would be nice to know, specifically
/// what a channel is configured for, i.e. DigitalInput, I2C TX, UART RX, etc.
/// </summary>
public enum ChannelConfigurationType
{
    /// <summary>
    /// Not configured
    /// </summary>
    None,
    /// <summary>
    /// Configured as a digital output
    /// </summary>
    DigitalOutput,
    /// <summary>
    /// Configured as a digital input
    /// </summary>
    DigitalInput,
    /// <summary>
    /// Configured as an analog output
    /// </summary>
    AnalogOutput,
    /// <summary>
    /// Configured as an analog input
    /// </summary>
    AnalogInput,
    /// <summary>
    /// Configured for pulse width modulation (PWM)
    /// </summary>
    PWM,
    /// <summary>
    /// Configured for serial peripheral interface (SPI) communication
    /// </summary>
    SPI,
    /// <summary>
    /// Configured for inter-integrated circuit (I2C) communication
    /// </summary>
    I2C,
    /// <summary>
    /// Configured for controller area network (CAN) communication
    /// </summary>
    CAN,
    /// <summary>
    /// Configured for UART communication
    /// </summary>
    UART
}


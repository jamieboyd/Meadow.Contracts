namespace Meadow.Hardware
{
    /// <summary>
    /// Represents the pinout for an ESP coprocessor.
    /// </summary>
    public interface IEspCoprocessorPinout
    {
        /// <summary>
        /// Gets the pin connected to ESP_MOSI.
        /// </summary>
        IPin ESP_MOSI => ESP_COPI;

        /// <summary>
        /// Gets the pin connected to ESP_COPI.
        /// </summary>
        IPin ESP_COPI { get; }

        /// <summary>
        /// Gets the pin connected to ESP_MISO.
        /// </summary>
        IPin ESP_MISO => ESP_CIPO;

        /// <summary>
        /// Gets the pin connected to ESP_CIPO.
        /// </summary>
        IPin ESP_CIPO { get; }

        /// <summary>
        /// Gets the pin connected to ESP_CLK.
        /// </summary>
        IPin ESP_CLK { get; }

        /// <summary>
        /// Gets the pin connected to ESP_CS.
        /// </summary>
        IPin ESP_CS { get; }

        /// <summary>
        /// Gets the pin connected to ESP_BOOT.
        /// </summary>
        IPin ESP_BOOT { get; }

        /// <summary>
        /// Gets the pin connected to ESP_RST.
        /// </summary>
        IPin ESP_RST { get; }

        /// <summary>
        /// Gets the pin connected to ESP_UART_RX.
        /// </summary>
        IPin ESP_UART_RX { get; }

        /// <summary>
        /// Gets the pin connected to ESP_UART_TX.
        /// </summary>
        IPin ESP_UART_TX { get; }
    }
}
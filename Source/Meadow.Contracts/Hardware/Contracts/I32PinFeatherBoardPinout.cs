namespace Meadow.Hardware;

/// <summary>
/// Represents the pinout definition for the 32-pin Feather board.
/// </summary>
public interface I32PinFeatherBoardPinout : IPinDefinitions
{
    /// <summary>Pin A00 on the 32-pin Feather board.</summary>
    IPin A00 { get; }

    /// <summary>Pin A01 on the 32-pin Feather board.</summary>
    IPin A01 { get; }

    /// <summary>Pin A02 on the 32-pin Feather board.</summary>
    IPin A02 { get; }

    /// <summary>Pin A03 on the 32-pin Feather board.</summary>
    IPin A03 { get; }

    /// <summary>Pin A04 on the 32-pin Feather board.</summary>
    IPin A04 { get; }

    /// <summary>Pin A05 on the 32-pin Feather board.</summary>
    IPin A05 { get; }

    /// <summary>Pin SCK on the 32-pin Feather board.</summary>
    IPin SCK { get; }

    /// <summary>Alias for COPI (MOSI) on the 32-pin Feather board.</summary>
    IPin MOSI => COPI;

    /// <summary>Pin COPI (MOSI) on the 32-pin Feather board.</summary>
    IPin COPI { get; }

    /// <summary>Alias for CIPO (MISO) on the 32-pin Feather board.</summary>
    IPin MISO => CIPO;

    /// <summary>Pin CIPO (MISO) on the 32-pin Feather board.</summary>
    IPin CIPO { get; }

    /// <summary>Pin D01 on the 32-pin Feather board.</summary>
    IPin D01 { get; }

    /// <summary>Pin D00 on the 32-pin Feather board.</summary>
    IPin D00 { get; }

    /// <summary>Pin D02 on the 32-pin Feather board.</summary>
    IPin D02 { get; }

    /// <summary>Pin D03 on the 32-pin Feather board.</summary>
    IPin D03 { get; }

    /// <summary>Pin D04 on the 32-pin Feather board.</summary>
    IPin D04 { get; }

    /// <summary>Pin D05 on the 32-pin Feather board.</summary>
    IPin D05 { get; }

    /// <summary>Pin D06 on the 32-pin Feather board.</summary>
    IPin D06 { get; }

    /// <summary>Pin D07 on the 32-pin Feather board.</summary>
    IPin D07 { get; }

    /// <summary>Pin D08 on the 32-pin Feather board.</summary>
    IPin D08 { get; }

    /// <summary>Pin D09 on the 32-pin Feather board.</summary>
    IPin D09 { get; }

    /// <summary>Pin D10 on the 32-pin Feather board.</summary>
    IPin D10 { get; }

    /// <summary>Pin D11 on the 32-pin Feather board.</summary>
    IPin D11 { get; }

    /// <summary>Pin D12 on the 32-pin Feather board.</summary>
    IPin D12 { get; }

    /// <summary>Pin D13 on the 32-pin Feather board.</summary>
    IPin D13 { get; }

    /// <summary>Pin D14 on the 32-pin Feather board.</summary>
    IPin D14 { get; }

    /// <summary>Pin D15 on the 32-pin Feather board.</summary>
    IPin D15 { get; }

    /// <summary>Alias for D07 (I2C SDA) on the 32-pin Feather board.</summary>
    IPin I2C_SDA => D07;

    /// <summary>Alias for D08 (I2C SCL) on the 32-pin Feather board.</summary>
    IPin I2C_SCL => D08;
}

using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Define a contract for general peripheral communications classes.
    /// </summary>
    public interface IByteCommunications
    {
        /// <summary>
        /// Reads data from the peripheral.
        /// </summary>
        /// <param name="readBuffer">The buffer to read from the peripheral into.</param>
        /// <remarks>
        /// The number of bytes to be read is determined by the length of the
        /// `readBuffer`.
        /// </remarks>
        void Read(Span<byte> readBuffer);

        /// <summary>
        /// Reads data from the peripheral starting at the specified address.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="readBuffer"></param>
        void ReadRegister(byte address, Span<byte> readBuffer);

        /// <summary>
        /// Read a register from the peripheral.
        /// </summary>
        /// <param name="address">Address of the register to read.</param>
        byte ReadRegister(byte address);

        /// <summary>
        /// Read an unsigned short from a register.
        /// </summary>
        /// <param name="address">Register address of the low byte (the high byte will follow).</param>
        /// <param name="order">Order of the bytes in the register (little endian is the default).</param>
        /// <returns>Value read from the register.</returns>
        ushort ReadRegisterAsUShort(byte address, ByteOrder order = ByteOrder.LittleEndian);

        /// <summary>
        /// Write a single byte to the peripheral.
        /// </summary>
        /// <param name="value">Value to be written (8-bits).</param>
        void Write(byte value);

        /// <summary>
        /// Write an array of bytes to the peripheral.
        /// </summary>
        /// <param name="writeBuffer">A buffer of byte values to be written.</param>
        void Write(Span<byte> writeBuffer);

        /// <summary>
        /// Write data to a register in the peripheral.
        /// </summary>
        /// <param name="address">Address of the register to write to.</param>
        /// <param name="value">Data to write into the register.</param>
        void WriteRegister(byte address, byte value);

        /// <summary>
        /// Write data to a register in the peripheral.
        /// </summary>
        /// <param name="address">Address of the register to write to.</param>
        /// <param name="writeBuffer">A buffer of byte values to be written.</param>
        /// <param name="order">Indicate if the data should be written as big or little endian.</param>
        void WriteRegister(byte address, Span<byte> writeBuffer, ByteOrder order = ByteOrder.LittleEndian);

        /// <summary>
        /// Write an unsigned short to the peripheral.
        /// </summary>
        /// <param name="address">Address to write the first byte to.</param>
        /// <param name="value">Value to be written (16-bits).</param>
        /// <param name="order">Indicate if the data should be written as big or little endian.</param>
        void WriteRegister(byte address, ushort value, ByteOrder order = ByteOrder.LittleEndian);

        /// <summary>
        /// Write an unsigned integer to the peripheral.
        /// </summary>
        /// <param name="address">Address to write the first byte to.</param>
        /// <param name="value">Value to be written.</param>
        /// <param name="order">Indicate if the data should be written as big or little endian.</param>
        void WriteRegister(byte address, uint value, ByteOrder order = ByteOrder.LittleEndian);

        /// <summary>
        /// Write an unsigned long to the peripheral.
        /// </summary>
        /// <param name="address">Address to write the first byte to.</param>
        /// <param name="value">Value to be written.</param>
        /// <param name="order">Indicate if the data should be written as big or little endian.</param>
        void WriteRegister(byte address, ulong value, ByteOrder order = ByteOrder.LittleEndian);

        /// <summary>
        /// Write data to followed by read data from the peripheral.
        /// </summary>
        /// <param name="writeBuffer">Data to write</param>
        /// <param name="readBuffer">Buffer where read data will be written. Number of bytes read is determined by buffer size.</param>
        /// <param name="duplex">Whether the communication will happen in a half-duplex or full-duplex fashion.</param>
        void Exchange(Span<byte> writeBuffer, Span<byte> readBuffer, DuplexType duplex = DuplexType.Half);
    }
}
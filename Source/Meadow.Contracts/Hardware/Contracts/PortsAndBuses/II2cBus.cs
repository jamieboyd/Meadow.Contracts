using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Represents an I2C bus.
    /// </summary>
    public interface II2cBus : IDisposable
    {
        /// <summary>
        /// Gets or sets the bus clock speed.
        /// </summary>
        I2cBusSpeed BusSpeed { get; set; }

        /// <summary>
        /// Reads bytes from a peripheral.
        /// </summary>
        /// <param name="peripheralAddress">The I2C Address to read</param>
        /// <param name="readBuffer">Buffer used for data reception</param>
        /// <remarks>
        /// The number of bytes to be written will be determined by the length
        /// of the byte array.
        /// </remarks>
        /// <returns></returns>
        void Read(byte peripheralAddress, Span<byte> readBuffer);

        /// <summary>
        /// Writes a number of bytes to the bus.
        /// </summary>
        /// <remarks>
        /// The number of bytes to be written will be determined by the length of the byte array.
        /// </remarks>
        /// <param name="peripheralAddress">Address of the I2C peripheral.</param>
        /// <param name="writeBuffer">Data to be written.</param>
        void Write(byte peripheralAddress, Span<byte> writeBuffer);

        /// <summary>
        /// Writes data from the write buffer to a peripheral on the bus, then
        /// resets the bus and reads the return data into the read buffer.
        /// </summary>
        /// <param name="peripheralAddress">Address of the I2C peripheral.</param>
        /// <param name="writeBuffer">Buffer to read data from.</param>
        /// <param name="readBuffer">Buffer to read returning data into.</param>
        void Exchange(byte peripheralAddress, Span<byte> writeBuffer, Span<byte> readBuffer);
    }
}

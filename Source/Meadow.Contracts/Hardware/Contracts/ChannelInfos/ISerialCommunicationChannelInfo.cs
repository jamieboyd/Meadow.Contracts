namespace Meadow.Hardware
{
    /// <summary>
    /// Represents the communication channel information for a serial communication channel.
    /// </summary>
    public interface ISerialCommunicationChannelInfo : ICommunicationChannelInfo
    {
        /// <summary>
        /// Gets the serial direction type.
        /// </summary>
        SerialDirectionType SerialDirection { get; }
    }
}
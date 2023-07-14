namespace Meadow.Hardware
{
    /// <summary>
    /// Represents the communication channel information for a UART channel.
    /// </summary>
    public interface IUartChannelInfo : IDigitalChannelInfo, ISerialCommunicationChannelInfo
    {
        //TODO: what else should this have? allowed speeds?
        // what does it share with the other digital comm protocols?
        // if it does, we need an IDigitalCommunicationProtocol or something?
    }
}
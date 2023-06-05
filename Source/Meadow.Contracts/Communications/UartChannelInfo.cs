namespace Meadow.Hardware
{
    /// <summary>
    /// Represents information about a UART channel.
    /// </summary>
    public class UartChannelInfo : DigitalChannelInfoBase, IUartChannelInfo
    {
        /// <summary>
        /// Gets the serial direction type of the UART channel.
        /// </summary>
        public SerialDirectionType SerialDirection { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UartChannelInfo"/> class.
        /// </summary>
        /// <param name="name">The name of the UART channel.</param>
        /// <param name="serialDirection">The serial direction type of the UART channel.</param>
        /// <param name="pullDownCapable">Indicates whether the UART channel is capable of pull-down.</param>
        /// <param name="pullUpCapable">Indicates whether the UART channel is capable of pull-up.</param>
        public UartChannelInfo(string name,
                               SerialDirectionType serialDirection,
                               bool pullDownCapable = false,
                               bool pullUpCapable = false)
            : base(name,
                   inputCapable: true,
                   outputCapable: true,
                   interruptCapable: false, // ?? i mean, technically, yes, but will we have events?
                   pullDownCapable: pullDownCapable,
                   pullUpCapable: pullUpCapable,
                   inverseLogic: false) //TODO: switch to C# 7.2+ to get rid of trailing names
        {
            this.SerialDirection = serialDirection;
        }
    }
}
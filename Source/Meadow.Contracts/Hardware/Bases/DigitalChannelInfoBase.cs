using System;

namespace Meadow.Hardware
{
    public class DigitalChannelInfoBase : ChannelInfoBase, IDigitalChannelInfo
    {
        public bool InputCapable { get; protected set; }
        public bool OutputCapable { get; protected set; }
        public bool InterruptCapable { get; protected set; }
        public bool PullDownCapable { get; protected set; }
        public bool PullUpCapable { get; protected set; }
        public bool InverseLogic { get; protected set; }
        public int? InterruptGroup { get; protected set; }

        protected DigitalChannelInfoBase(
            string name,
            bool inputCapable,
            bool outputCapable,
            bool interruptCapable,
            bool pullDownCapable,
            bool pullUpCapable,
            bool inverseLogic,
            int? interruptGroup = null)
            : base(name)
        {
            InputCapable = inputCapable;
            OutputCapable = outputCapable;
            InterruptCapable = interruptCapable;
            PullDownCapable = pullDownCapable;
            PullUpCapable = pullUpCapable;
            InverseLogic = inverseLogic;
            InterruptGroup = interruptGroup;
        }
    }
}

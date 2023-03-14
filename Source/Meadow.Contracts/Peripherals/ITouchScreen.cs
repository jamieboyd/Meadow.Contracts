namespace Meadow.Hardware
{
    /// <summary>
    /// An event delegate for touchscreen events
    /// </summary>
    /// <param name="x">The horizontal position of the touch</param>
    /// <param name="y">the vertical position of the touch </param>
    public delegate void TouchEventHandler(int x, int y);

    /// <summary>
    /// Represents a touch screen device
    /// </summary>
    public interface ITouchScreen
    {
        /// <summary>
        /// Event fired when the touchscreen is pressed
        /// </summary>
        public event TouchEventHandler TouchDown;
        /// <summary>
        /// Event fired when the touchscreen is released
        /// </summary>
        public event TouchEventHandler TouchUp;
        /// <summary>
        /// Event fired when a cycle of press and release has occurred
        /// </summary>
        public event TouchEventHandler TouchClick;
    }
}
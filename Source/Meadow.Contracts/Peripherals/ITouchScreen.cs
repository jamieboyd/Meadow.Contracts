namespace Meadow.Hardware
{
    public delegate void TouchEventHandler(int x, int y);

    public interface ITouchScreen
    {
        public event TouchEventHandler TouchDown;
        public event TouchEventHandler TouchUp;
        public event TouchEventHandler TouchClick;
    }
}
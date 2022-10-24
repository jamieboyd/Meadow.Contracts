namespace Meadow.Hardware
{
    public interface ICounter
    {
        bool Enabled { get; set; }
        long Count { get; }
        void Reset();
    }
}
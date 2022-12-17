namespace Meadow
{
    public class StorageCapabilities
    {
        public bool HasSd { get; protected set; }

        public StorageCapabilities(
            bool hasSd)
        {
            this.HasSd = hasSd;
        }
    }
}


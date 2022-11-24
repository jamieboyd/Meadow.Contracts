using System.Collections.Generic;
using System.IO;

namespace Meadow
{
    public delegate void ExternalStorageEventHandler(IExternalStorage storage, ExternalStorageState state);

    public enum ExternalStorageState
    {
        Inserted,
        Ejected
    }

    public interface IExternalStorage
    {
        public DirectoryInfo Directory { get; } // this or string???
        public void Eject();
    }

    public partial interface IPlatformOS
    {
        public event ExternalStorageEventHandler ExternalStorageEvent;
        public IEnumerable<IExternalStorage> ExternalStorage { get; }
    }
}

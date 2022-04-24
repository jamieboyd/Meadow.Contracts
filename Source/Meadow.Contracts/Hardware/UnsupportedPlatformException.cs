using Meadow.Hardware;
using System;

namespace Meadow
{
    public class UnsupportedPlatformException : Exception
    {
        public MeadowPlatform CurrentPlatform { get; }

        public UnsupportedPlatformException(MeadowPlatform currentPlatform, string message)
            : base(message)
        {
            CurrentPlatform = currentPlatform;
        }
    }
}

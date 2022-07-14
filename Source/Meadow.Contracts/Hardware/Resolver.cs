using Meadow.Devices;
using Meadow.Logging;

namespace Meadow
{
    public static class Resolver
    {
        public static ServiceCollection Services { get; }

        static Resolver()
        {
            Services = new ServiceCollection();
            Services.Add(Services);
        }

        public static IApp App
        {
            get => Services?.Get<IApp>();
        }

        public static IMeadowDevice Device
        {
            get => Services?.Get<IMeadowDevice>();
        }

        public static Logger Log
        {
            get => Services?.Get<Logger>();
        }
    }
}

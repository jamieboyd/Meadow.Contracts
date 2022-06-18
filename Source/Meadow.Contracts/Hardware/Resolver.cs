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

        public static Logger Log
        {
            get => Services?.Get<Logger>();
        }
    }
}

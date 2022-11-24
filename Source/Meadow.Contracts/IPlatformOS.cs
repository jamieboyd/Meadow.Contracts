using Meadow.Units;

namespace Meadow
{
    /// <summary>
    /// Provides an abstraction for OS services such as configuration so that
    /// Meadow can operate on different OS's and platforms.
    /// </summary>
    public partial interface IPlatformOS : IPowerController
    {
        /// <summary>
        /// Initializes platform-specific OS features
        /// </summary>
        void Initialize();

        /// <summary>
        /// Gets the current CPU temperature
        /// </summary>
        /// <returns></returns>
        Temperature GetCpuTemperature();

        /// <summary>
        /// Gets the OS INtpClient instance
        /// </summary>
        public INtpClient NtpClient { get; }
    }
}

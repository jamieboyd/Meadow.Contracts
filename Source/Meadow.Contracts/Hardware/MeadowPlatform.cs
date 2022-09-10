namespace Meadow.Hardware
{
    /// <summary>
    /// Platform (hardware, etc) Meadow is currently executing on
    /// </summary>
    public enum MeadowPlatform
    {
        /// <summary>
        /// Current Platform is not resolvable
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// F7 Feather version 1 (revisions a -> d).
        /// </summary>
        F7FeatherV1 = 1,

        /// <summary>
        /// F7 Feather version 2 (revisions a -> c).
        /// </summary>
        F7FeatherV2 = 2,

        /// <summary>
        /// F7 Core Compute Module version 2.
        /// </summary>
        F7CoreComputeV2 = 3,

        /// <summary>
        /// Meadow for Linux
        /// </summary>
        MeadowForLinux,

        /// <summary>
        /// Meadow Simulation Platform
        /// </summary>
        MeadowSimulation
    }
}

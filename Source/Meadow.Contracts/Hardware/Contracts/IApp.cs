namespace Meadow
{
    using System;
    using System.Threading.Tasks;
    /// <summary>
    /// Contract for Meadow applications. Provides a way for the Meadow OS to
    /// communicate with Meadow applications when system events are happening.
    /// </summary>
    public interface IApp
    {
        void InvokeOnMainThread(Action<object> action, object? state = null);

        public static Version Version { get; } = new Version("1.0.0");

        /// <summary>
        /// Called when the application is being brought up.
        /// </summary>
        public Task Initialize();

        /// <summary>
        /// The core of the app's work and logic
        /// </summary>
        public Task Run();

        /// <summary>
        /// Called if the app is being brought down.
        /// </summary>
        public void OnShutdown();

        /// <summary>
        /// Called if a failure occurred while running the app
        /// </summary>
        public void OnError(Exception e, out bool recovered);

        /// <summary>
        /// Called after a full app failure
        /// </summary>
        public void OnRecovery(Exception e);

        /// <summary>
        /// Called when the application is about to update itself.
        /// </summary>
        public void OnUpdate(Version newVersion, out bool approveUpdate);
        /// <summary>
        /// Called when the application has updated itself.
        /// </summary>
        public void OnUpdateComplete(Version oldVersion, out bool rollbackUpdate);
    }
}
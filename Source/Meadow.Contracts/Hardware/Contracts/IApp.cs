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
        public void OnShutdown(out bool complete, Exception? e = null);

        /// <summary>
        /// Called if a failure occured while running the app
        /// </summary>
        public void OnError(Exception e, out bool recovered);

        /// <summary>
        /// Called when the application is put to sleep.
        /// </summary>
        public void OnSleep();

        /// <summary>
        /// Called when the application wakes up from sleep.
        /// </summary>
        public void OnResume();

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

        /// <summary>
        /// Called in case the OS needs to restart the app. Will have limited
        /// processing time.
        /// </summary>
        public void OnReset();
    }
}
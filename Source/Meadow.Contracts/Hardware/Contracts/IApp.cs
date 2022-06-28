namespace Meadow
{
    using System;
    using Meadow.Devices;
    using System.Threading.Tasks;
    /// <summary>
    /// Contract for Meadow applications. Provides a way for the Meadow OS to
    /// communicate with Meadow applications when system events are happening.
    /// </summary>
    public interface IApp
    {
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
        public void Shutdown(out bool complete, Exception? e = null);

        /// <summary>
        /// Called if a failure occured while running the app
        /// </summary>
        public void OnError(Exception e, out bool recovered);

        /// <summary>
        /// Called when the application is put to sleep.
        /// </summary>
        public void Sleep();

        /// <summary>
        /// Called when the application wakes up from sleep.
        /// </summary>
        public void Resume();

        /// <summary>
        /// Called after a full app failure
        /// </summary>
        public void Recovery(Exception e);

        /// <summary>
        /// Called when the application is about to update itself.
        /// </summary>
        public void Update(Version newVersion, out bool approveUpdate);
        /// <summary>
        /// Called when the application has updated itself.
        /// </summary>
        public void UpdateComplete(Version oldVersion, out bool rollbackUpdate);

        /// <summary>
        /// Called in case the OS needs to restart the app. Will have limited
        /// processing time.
        /// </summary>
        public void Reset();
    }
}
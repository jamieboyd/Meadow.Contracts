using System;

namespace Meadow
{
    public delegate void PowerTransitionHandler();

    public interface IPowerController
    {
        /// <summary>
        /// Event called before a software reset
        /// </summary>
        event PowerTransitionHandler BeforeReset;
        /// <summary>
        /// Event called before Sleep mode
        /// </summary>
        event PowerTransitionHandler BeforeSleep;
        /// <summary>
        /// Event called after returning from Sleep mode
        /// </summary>
        event PowerTransitionHandler AfterWake;

        /// <summary>
        /// Resets the device
        /// </summary>
        void Reset();

        /// <summary>
        /// Put the device into low-power (sleep) mode for the specified amount of time.
        /// </summary>
        /// <param name="duration">Amount of time to sleep</param>
        void Sleep(TimeSpan duration);

        /// <summary>
        /// Put the device into low-power (sleep) mode until the specified time.
        /// </summary>
        /// <param name="wakeTime">UTC time to wake</param>
        public void Sleep(DateTime wakeTime)
        {
            if (wakeTime.Kind == DateTimeKind.Local)
            {
                throw new ArgumentException("Wake time must be in UTC");
            }

            Sleep(wakeTime - DateTime.UtcNow);
        }

        void RegisterForSleep(ISleepAwarePeripheral peripheral);
    }
}

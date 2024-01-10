using Meadow.Hardware;
using System;

namespace Meadow
{
    /// <summary>
    /// Delegate representing a power transition event handler.
    /// </summary>
    public delegate void PowerTransitionHandler();

    /// <summary>
    /// Interface for controlling power-related functionality of the device.
    /// </summary>
    public interface IPowerController
    {
        /// <summary>
        /// Event called before a software reset.
        /// </summary>
        event PowerTransitionHandler BeforeReset;

        /// <summary>
        /// Event called before entering sleep mode.
        /// </summary>
        event PowerTransitionHandler BeforeSleep;

        /// <summary>
        /// Event called after waking from sleep mode.
        /// </summary>
        event PowerTransitionHandler AfterWake;

        /// <summary>
        /// Resets the device.
        /// </summary>
        void Reset();

        /// <summary>
        /// Puts the device into low-power (sleep) mode for the specified amount of time.
        /// </summary>
        /// <param name="duration">The amount of time to sleep.</param>
        void Sleep(TimeSpan duration);

        /// <summary>
        /// Puts the device into low-power (sleep) mode until the specified time.
        /// </summary>
        /// <param name="wakeTime">The UTC time to wake.</param>
        public void Sleep(DateTime wakeTime)
        {
            if (wakeTime.Kind == DateTimeKind.Local)
            {
                throw new ArgumentException("Wake time must be in UTC");
            }

            Sleep(wakeTime - DateTime.UtcNow);
        }

        /// <summary>
        /// Puts the device into low-power (sleep) mode until an interrupt occurs
        /// </summary>
        /// <param name="interruptPin">The IPin to monitor for the wake interrupt.</param>
        /// <param name="interruptMode">The interrupt mode used for wake</param>
        /// <param name="resistorMode">The resistor mode used for wake</param>
        void Sleep(IPin interruptPin, InterruptMode interruptMode, ResistorMode resistorMode = ResistorMode.Disabled);

        /// <summary>
        /// Registers a peripheral to be aware of sleep mode.
        /// </summary>
        /// <param name="peripheral">The peripheral to register.</param>
        void RegisterForSleep(ISleepAwarePeripheral peripheral);
    }
}

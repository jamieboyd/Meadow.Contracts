using System;
using System.Threading.Tasks;

namespace Meadow.Peripherals.Sensors
{
    /// <summary>
    /// Abstraction for a sampling/observable sensor
    /// </summary>
    public interface ISamplingSensor<UNIT> : ISensor
    {
        /// <summary>
        /// A `TimeSpan` that specifies how long to
        /// wait between readings. This value influences how often `*Updated`
        /// events are raised and `IObservable` consumers are notified.
        /// </summary>
        public TimeSpan UpdateInterval { get; }

        /// <summary>
        /// Gets a value indicating whether the sensor is currently in a sampling
        /// loop. Call StartSampling() to spin up the sampling process.
        /// </summary>
        /// <value><c>true</c> if sampling; otherwise, <c>false</c>.</value>
        public bool IsSampling { get; }

        /// <summary>
        /// Starts updating the sensor on the updateInterval frequency specified.
        ///
        /// This method also starts raising `Updated` events and notifying
        /// IObservable subscribers. Use the `updateInterval` parameter
        /// to specify how often events and notifications are raised/sent.
        /// </summary>
        /// <param name="updateInterval">A `TimeSpan` that specifies how long to
        /// wait between readings. This value influences how often `*Updated`
        /// events are raised and `IObservable` consumers are notified.
        /// The default is 5 seconds.</param>
        public void StartUpdating(TimeSpan? updateInterval = null);

        /// <summary>
        /// Stops sampling the sensor.
        /// </summary>
        public void StopUpdating();

        /// <summary>
        /// Convenience method to get the current sensor readings. For frequent reads, use
        /// StartSampling() and StopSampling() in conjunction with the SampleBuffer.
        /// </summary>
        public Task<UNIT> Read();
    }
}
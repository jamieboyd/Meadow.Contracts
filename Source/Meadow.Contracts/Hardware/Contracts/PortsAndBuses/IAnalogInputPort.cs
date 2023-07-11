using Meadow.Units;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for ports that implement an analog input channel.
    /// </summary>
    public interface IAnalogInputPort : IAnalogPort, IObservable<IChangeResult<Voltage>>
    {
        /// <summary>
        /// Raised when the value of the reading changes.
        /// </summary>
        event EventHandler<IChangeResult<Voltage>> Updated;

        /// <summary>
        /// Gets the sample buffer.
        /// </summary>
        IList<Voltage> VoltageSampleBuffer { get; }

        /// <summary>
        /// The maximum voltage that the Analog Port can read. Typically 3.3V.
        /// This value is used to convert raw ADC values into voltage.
        /// </summary>
        Voltage ReferenceVoltage { get; }

        /// <summary>
        /// Gets the average value of the values in the buffer. Use in conjunction
        /// with StartSampling() for long-running analog sampling. For occasional
        /// sampling, use Read().
        /// </summary>
        Voltage Voltage { get; }

        /// <summary>
        /// A <see cref="TimeSpan"/> that specifies how long to wait between readings.
        /// This value influences how often Updated events are raised and IObservable
        /// consumers are notified.
        /// </summary>
        public TimeSpan UpdateInterval { get; }

        /// <summary>
        /// Number of samples to take per reading. If > 0, then the port will
        /// take multiple readings and automatically average them to reduce noise,
        /// a process known as oversampling.
        /// </summary>
        public int SampleCount { get; }

        /// <summary>
        /// Duration in between samples when oversampling.
        /// </summary>
        public TimeSpan SampleInterval { get; }

        /// <summary>
        /// Gets the current voltage. For frequent reads, use StartUpdating() and StopUpdating()
        /// in conjunction with the SampleBuffer.
        /// </summary>
        /// <returns>The current voltage.</returns>
        Task<Voltage> Read();

        /// <summary>
        /// Starts continuously sampling the analog port.
        ///
        /// This method also starts raising Updated events and notifying IObservable
        /// subscribers. Use the updateInterval parameter to specify how often events
        /// and notifications are raised.
        /// </summary>
        /// <param name="updateInterval">The interval between readings.</param>
        void StartUpdating(TimeSpan? updateInterval = null);

        /// <summary>
        /// Stops sampling the analog port.
        /// </summary>
        void StopUpdating();

        /// <summary>
        /// Creates an observer for monitoring changes in the analog input voltage.
        /// </summary>
        /// <param name="handler">The handler to be called when a change occurs.</param>
        /// <param name="filter">An optional filter predicate for filtering changes.</param>
        /// <returns>The created observer.</returns>
        public static FilterableChangeObserver<Voltage> CreateObserver(
            Action<IChangeResult<Voltage>> handler,
            Predicate<IChangeResult<Voltage>>? filter = null)
        {
            return new FilterableChangeObserver<Voltage>(
                handler, filter);
        }
    }
}

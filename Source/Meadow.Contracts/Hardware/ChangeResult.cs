using Meadow.Units;

namespace Meadow
{
    /// <summary>
    /// Represents a change result from an event. Contains a `New` and an optional
    /// `Old` value which will likely be null on the first result within an event
    /// series.
    /// </summary>
    /// <typeparam name="UNIT">A unit type that carries the result data. Must be
    /// a `struct`. Will most often be a unit such as `Temperature` or `Mass`,
    /// but can also be a primitive type such as `int`, `float`, or even
    /// `DateTime`.</typeparam>
    public struct ChangeResult<UNIT> : IChangeResult<UNIT>
        where UNIT : struct
    {
        /// <inheritdoc/>
        public UNIT New { get; set; }
        /// <inheritdoc/>
        public UNIT? Old { get; set; }

        /// <summary>
        /// Creates a new ChangeResult.
        /// </summary>
        /// <param name="newValue">The value at the time of this event or notification.</param>
        /// <param name="oldValue">The previous value before this event or notification, or null if there was no previous value.</param>
        public ChangeResult(UNIT newValue, UNIT? oldValue)
        {
            New = newValue;
            Old = oldValue;
        }
    }
}
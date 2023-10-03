namespace Meadow
{
    /// <summary>
    /// Contract for change notifications.
    /// </summary>
    /// <typeparam name="UNIT">A unit type that carries the result data. Must be
    /// a `struct`. Will most often be a unit such as `Temperature` or `Mass`,
    /// but can also be a primitive type such as `int`, `float`, or even
    /// `DateTime`.</typeparam>
    public interface IChangeResult<UNIT> where UNIT : struct
    {
        /// <summary>
        /// The value at the time of this event or notification.
        /// </summary>
        UNIT New { get; set; }
        /// <summary>
        /// The previous value before this event or notification, or null if there was no previous value.
        /// </summary>
        UNIT? Old { get; set; }
    }
}

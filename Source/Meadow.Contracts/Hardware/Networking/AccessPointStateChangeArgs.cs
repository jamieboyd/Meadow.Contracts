using System;

namespace Meadow.Hardware
{
    /// <summary>
    /// Provide information about a change of state for the access point.
    /// </summary>
	public class AccessPointStateChangeArgs : EventArgs
	{
        /// <summary>
        /// Date and time the event was generated.
        /// </summary>
        public DateTime When { get; private set; }

        /// <summary>
        /// Create a new AccessPointStateChangeEventArgs object.
        /// </summary>
        public AccessPointStateChangeArgs()
		{
            When = DateTime.Now;
		}
	}
}


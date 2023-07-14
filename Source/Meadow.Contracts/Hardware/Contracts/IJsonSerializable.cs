namespace Meadow.Gateways.Bluetooth
{
    /// <summary>
    /// Represents an interface for objects that can be serialized to JSON.
    /// </summary>
    public interface IJsonSerializable
    {
        /// <summary>
        /// Converts the object to its JSON representation.
        /// </summary>
        /// <returns>A string containing the JSON representation of the object.</returns>
        string ToJson();
    }
}
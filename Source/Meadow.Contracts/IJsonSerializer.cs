namespace Meadow;

/// <summary>
/// Provides an abstraction for a serializer tha can convert between objects and JSON strings
/// </summary>
public interface IJsonSerializer
{
    /// <summary>
    /// Deserializes a provided string into a typed object
    /// </summary>
    /// <typeparam name="T">The type to deserialize to</typeparam>
    /// <param name="json">The source JSON</param>
    /// <returns>An instance of T</returns>
    T Deserialize<T>(string json);
    /// <summary>
    /// Serializes an object to a JSON representation
    /// </summary>
    /// <param name="source">An object to serialize</param>
    /// <returns>A JSON representationof the source object</returns>
    string? Serialize(object source);
}

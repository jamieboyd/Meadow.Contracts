using System;
using System.Text;

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
    /// Deserializes a provided string into a typed object
    /// </summary>
    /// <param name="json">The source JSON</param>
    /// <param name="type">The type to deserialize to</param>
    /// <returns>An instance of 'type'</returns>
    object Deserialize(string json, Type type);
    /// <summary>
    /// Serializes an object to a JSON representation
    /// </summary>
    /// <param name="source">An object to serialize</param>
    /// <returns>A JSON representationof the source object</returns>
    string? Serialize(object source);

    /// <summary>
    /// Deserializes a provided string into a typed object
    /// </summary>
    /// <param name="encodedJson">UTF8-encoded JSON string</param>
    /// <param name="type">The type to deserialize to</param>
    /// <returns>An instance of 'type'</returns>
    object Deserialize(byte[] encodedJson, Type type)
    {
        return Deserialize(
            Encoding.UTF8.GetString(encodedJson),
            type);
    }
    /// <summary>
    /// Deserializes a provided string into a typed object
    /// </summary>
    /// <typeparam name="T">The type to deserialize to</typeparam>
    /// <param name="encodedJson">UTF8-encoded JSON string</param>
    /// <returns>An instance of T</returns>
    T Deserialize<T>(byte[] encodedJson)
    {
        return Deserialize<T>(
            Encoding.UTF8.GetString(encodedJson));
    }
}

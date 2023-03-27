using System.Collections.Generic;

namespace Meadow.Hardware;

/// <summary>
/// Provides base implementation for IO pins.
/// </summary>
public class Pin : IPin
{
    /// <summary>
    /// Gets a list of IChannelInfo the pin supports
    /// </summary>
    public IList<IChannelInfo>? SupportedChannels { get; protected set; }

    /// <summary>
    /// Gets the IPinController associated with the pin
    /// </summary>
    public IPinController Controller { get; }

    /// <summary>
    /// Gets the name of the pin
    /// </summary>
    public string Name { get; protected set; }
    /// <summary>
    /// Identifier that the parent Device can use to identify the I/O (address, port, pin, etc)
    /// </summary>
    /// <value>The key.</value>
    public object Key { get; protected set; }

    /// <summary>
    /// Constructor for a Pin
    /// </summary>
    /// <param name="controller"></param>
    /// <param name="name"></param>
    /// <param name="key"></param>
    /// <param name="supportedChannels"></param>
    public Pin(IPinController controller, string name, object key, IList<IChannelInfo>? supportedChannels)
    {
        Controller = controller;
        Name = name;
        Key = key;
        SupportedChannels = supportedChannels;
    }

    /// <summary>
    /// Returns a string that represents the pin
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return Name;
    }

    /// <summary>
    /// Indicates whether the specified object is equal to the current object
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public virtual bool Equals(IPin other)
    {
        if (other == null) return false;
        return Key.Equals(other.Key);
    }

    /// <summary>
    /// Indicates whether the specified object is equal to the current object
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj)
    {
        if (obj is IPin { } p)
        {
            return p.Equals(this);
        }
        return false;
    }

    /// <summary>
    /// Serves as the hash function for a pin object
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode()
    {
        return Key.GetHashCode();
    }
}
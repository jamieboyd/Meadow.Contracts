namespace Meadow;

/// <summary>
/// provides an abstraction for platform cryptography capabilities
/// </summary>
public interface ICryptographyService
{
    /// <summary>
    /// Retrieves the device's public key in PEM format
    /// </summary>
    /// <returns>A public key, including header and footer, or null if none is found</returns>
    string? GetPublicKeyInPemFormat();

    /// <summary>
    /// Retrieves the device's private key in PEM format
    /// </summary>
    /// <returns>A private key, including header and footer, or null if none is found</returns>
    string? GetPrivateKeyInPemFormat();
}

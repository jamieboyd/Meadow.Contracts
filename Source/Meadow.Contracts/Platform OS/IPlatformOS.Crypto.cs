namespace Meadow;

public partial interface IPlatformOS
{
    /// <summary>
    /// Retrieves the device's public key in PEM format
    /// </summary>
    /// <returns>A public key, including header and footer, or null if none is found</returns>
    string? GetPublicKeyInPemFormat();

    /// <summary>
    /// Performs RSA decryption of a value using the Meadow device certificate.
    /// </summary>
    /// <remarks>
    /// This method is used by the Update Service
    /// </remarks>
    /// <param name="encryptedValue">The value to decrypt</param>
    /// <param name="privateKeyPem">The private key to use for decryption (in PEM format)</param>
    /// <returns>The decrypted value</returns>
    public byte[] RsaDecrypt(byte[] encryptedValue, string privateKeyPem);

    /// <summary>
    /// Performs AES decryption of a value using the Meadow device certificate.
    /// </summary>
    /// <remarks>
    /// This method is used by the Update Service
    /// </remarks>
    /// <param name="encryptedValue">The value to decrypt</param>
    /// <param name="iv">The initialization vector to use for decryption</param>
    /// <param name="key">The key used for encrypting the buffer</param>
    /// <returns>The decrypted value</returns>
    public byte[] AesDecrypt(byte[] encryptedValue, byte[] key, byte[] iv);
}

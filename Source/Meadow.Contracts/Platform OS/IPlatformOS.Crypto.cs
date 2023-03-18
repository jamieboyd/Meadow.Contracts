namespace Meadow;

public partial interface IPlatformOS
{
    /// <summary>
    /// Performs RSA decryption of a value using the Meadow device certificate.
    /// </summary>
    /// <remarks>
    /// This method is used by the Update Service
    /// </remarks>
    /// <param name="encryptedValue">The value to decrypt</param>
    /// <returns>The decrypted value</returns>
    public byte[] RsaDecrypt(byte[] encryptedValue);
    /// <summary>
    /// Performs AES decryption of a value using the Meadow device certificate.
    /// </summary>
    /// <remarks>
    /// This method is used by the Update Service
    /// </remarks>
    /// <param name="encryptedValue">The value to decrypt</param>
    /// <param name="iv">The initialization vector to use for decryption</param>
    /// <returns>The decrypted value</returns>
    public byte[] AesDecrypt(byte[] encryptedValue, byte[] iv);
}

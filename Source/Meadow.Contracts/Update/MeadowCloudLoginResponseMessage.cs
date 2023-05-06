namespace Meadow.Update;

/// <summary>
/// Encapsulation of the JSON response message Meadow Cloud returns for Login requests
/// </summary>
public class MeadowCloudLoginResponseMessage
{
    /// <summary>
    /// An encrypted authentication key
    /// </summary>
    public string EncryptedKey { get; set; } = default!;
    /// <summary>
    /// An encrypted authentication token
    /// </summary>
    public string EncryptedToken { get; set; } = default!;
    /// <summary>
    /// An encryption initialization vector
    /// </summary>
    public string Iv { get; set; } = default!;
}

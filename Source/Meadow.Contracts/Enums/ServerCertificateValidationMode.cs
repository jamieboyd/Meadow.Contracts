using System;

namespace Meadow;

/// <summary>
/// Enum representing different server certificate validation modes for TLS protocols.
/// </summary>
[Flags]
public enum ServerCertificateValidationMode
{
    /// <summary>
    /// No certificate validation is performed (Insecure)
    /// </summary>
    None = 0,

    /// <summary>
    /// Certificate validation is optional. Handshake continues even if verification fails
    /// </summary>
    Optional = 1,

    /// <summary>
    /// Peer must present a valid certificate; handshake is aborted if verification fails
    /// </summary>
    Required = 2
}
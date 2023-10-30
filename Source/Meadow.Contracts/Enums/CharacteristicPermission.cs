using System;

namespace Meadow.Gateways.Bluetooth;

/// <summary>
/// Specifies the permissions for accessing a Bluetooth characteristic.
/// </summary>
[Flags]
public enum CharacteristicPermission : short
{
    /// <summary>
    /// Read permission.
    /// </summary>
    Read = 1 << 0,
    /// <summary>
    /// Read permission with encryption.
    /// </summary>
    ReadEncrypted = 1 << 1,
    /// <summary>
    /// Read permission with encryption and Man-in-the-Middle (MITM) protection.
    /// </summary>
    ReadEncMITM = 1 << 2,

    // WHERE IS 1 << 3?

    /// <summary>
    /// Write permission.
    /// </summary>
    Write = 1 << 4,
    /// <summary>
    /// Write permission with encryption.
    /// </summary>
    WriteEncrypted = 1 << 5,
    /// <summary>
    /// Write permission with encryption and Man-in-the-Middle (MITM) protection.
    /// </summary>
    WriteEncMITM = 1 << 6,
    /// <summary>
    /// Write permission with signature.
    /// </summary>
    WriteSigned = 1 << 7,
    /// <summary>
    /// Write permission with signature and Man-in-the-Middle (MITM) protection.
    /// </summary>
    WriteSignedMITM = 1 << 8
}

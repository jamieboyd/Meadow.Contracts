using System;
using System.Threading.Tasks;

namespace Meadow.Cloud;

/// <summary>
/// An abstraction for the Meadow.Cloud service
/// </summary>
public interface IMeadowCloudService
{
    /// <summary>
    /// Event raised when an error occurs
    /// </summary>
    event EventHandler<string> ServiceError;

    /// <summary>
    /// The current JWT
    /// </summary>
    string? CurrentJwt { get; }

    /// <summary>
    /// Authenticates with the Meadow.Cloud service
    /// </summary>
    Task<bool> Authenticate();

    /// <summary>
    /// Sends a log message to the Meadow.Cloud service
    /// </summary>
    /// <param name="cloudLog">The log entry to send</param>
    Task<bool> SendLog(CloudLog cloudLog);

    /// <summary>
    /// Sends a CloudEvent to the Meadow.Cloud service
    /// </summary>
    /// <param name="cloudEvent"></param>
    /// <returns></returns>
    Task<bool> SendEvent(CloudEvent cloudEvent);
}
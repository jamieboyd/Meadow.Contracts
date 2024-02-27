using System;

namespace Meadow.Update;

/// <summary>
/// Describes a callback delegate for IUpdateService events
/// </summary>
/// <param name="updateService">The IUpdateService raising the event</param>
/// <param name="info">The UpdateInfo associated with the event</param>
public delegate void UpdateEventHandler(IUpdateService updateService, UpdateInfo info);

/// <summary>
/// Provides an abstraction for the Meadow Update Service
/// </summary>
public interface IUpdateService
{
    /// <summary>
    /// Event raised when an the state of the Update service changes
    /// </summary>
    event EventHandler<UpdateState> OnStateChanged;
    /// <summary>
    /// Event raised when an update is available on the defined Update server
    /// </summary>
    event UpdateEventHandler OnUpdateAvailable;
    /// <summary>
    /// Event raised with an update on download progress
    /// </summary>
    event UpdateEventHandler OnUpdateProgress;
    /// <summary>
    /// Event raised after an update package has been retrieved from the defined Update server
    /// </summary>
    event UpdateEventHandler OnUpdateRetrieved;
    /// <summary>
    /// Event raised after an update package has been successfully applied
    /// </summary>
    event UpdateEventHandler OnUpdateSuccess;
    /// <summary>
    /// Event raised if a failure occurs in an attempt to apply an update package
    /// </summary>
    event UpdateEventHandler OnUpdateFailure;
    /// <summary>
    /// Returns the update service's current ability to apply an update
    /// </summary>
    bool CanUpdate => State == UpdateState.Idle;
    /// <summary>
    /// Gets the current state of the service
    /// </summary>
    UpdateState State { get; }
    /// <summary>
    /// Retrieves an update package from the defined update server with the provided parameters
    /// </summary>
    /// <param name="updateInfo">The UpdateInfo describing the update to retrieve</param>
    void RetrieveUpdate(UpdateInfo updateInfo);
    /// <summary>
    /// Applies an already-retrieved update package with the provided parameters
    /// </summary>
    /// <param name="updateInfo">The UpdateInfo describing the update to apply</param>
    void ApplyUpdate(UpdateInfo updateInfo);
    /// <summary>
    /// Clears all locally stored update package information
    /// </summary>
    void ClearUpdates();
    /// <summary>
    /// Stops the service
    /// </summary>
    void Shutdown();
}

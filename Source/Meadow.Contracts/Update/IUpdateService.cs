namespace Meadow.Update;

/// <summary>
/// A delegate for events raised by an IUpdateService
/// </summary>
/// <param name="updateService">The IUpdateService that is the event source</param>
/// <param name="info">The UpdateInfo associated with the event</param>
public delegate void UpdateEventHandler(IUpdateService updateService, UpdateInfo info);

/// <summary>
/// A contract for update service implementations
/// </summary>
public interface IUpdateService
{
    event UpdateEventHandler OnUpdateAvailable;
    event UpdateEventHandler OnUpdateRetrieved;
    event UpdateEventHandler OnUpdateSuccess;
    event UpdateEventHandler OnUpdateFailure;

    bool CanUpdate => State == UpdateState.Idle;
    UpdateState State { get; }
    void RetrieveUpdate(UpdateInfo updateInfo);
    void ApplyUpdate(UpdateInfo updateInfo);
    void ClearUpdates();

    void Start();
    void Stop();
}

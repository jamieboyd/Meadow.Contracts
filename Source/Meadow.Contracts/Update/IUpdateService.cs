namespace Meadow.Update;

public delegate void UpdateEventHandler(IUpdateService updateService, UpdateInfo info);

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
    void Shutdown();
}

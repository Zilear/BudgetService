using BudgetService.Infrastructure.StorageClients.Common;

namespace BudgetService.Infrastructure.StorageService;

//TODO сделать реализацию сохранения в каждом типе хранилища через итератор
public interface IStorageService
{
    public Task<string> GetStorageInfo(
        IStorageClient storageClient,
        CancellationToken cancellationToken);

    public Task UpdateStorages(
        string newInfo,
        CancellationToken cancellationToken);

    public Task<string> GetInfoFromStorages(
        IStorageClient masterClient,
        CancellationToken cancellationToken);

    public Task SyncStorages(
        IStorageClient masterStorage,
        CancellationToken cancellationToken);
}
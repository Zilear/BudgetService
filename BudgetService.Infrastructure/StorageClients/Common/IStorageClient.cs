namespace BudgetService.Infrastructure.StorageClients.Common;

public interface IStorageClient
{
    public Task<string> GetStorageInfo(
        CancellationToken cancellationToken);

    public Task UpdateStorage(
        string newInfo,
        string path,
        CancellationToken cancellationToken);
}
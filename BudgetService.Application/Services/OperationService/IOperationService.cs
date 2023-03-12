using BudgetService.Domain.Entitiy;
using BudgetService.Domain.ValueObjects;

namespace Application.Services.OperationService;

public interface IOperationService
{
    public Task AddOperation(
        Operation operation,
        Account account,
        CancellationToken cancellationToken);

    public Task<IReadOnlyList<Operation>> GetAccountOperations(
        Account account,
        DateTime dateTimeFrom,
        DateTime dateTimeTo,
        CancellationToken cancellationToken);

    public Task EditOperation(
        Operation operation,
        CancellationToken cancellationToken);

    public Task DeleteOperation(
        OperationId operationId,
        CancellationToken cancellationToken);
}
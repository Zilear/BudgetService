using BudgetService.Domain.Entitiy;
using BudgetService.Domain.ValueObjects;

namespace Application.Services.TransactionService;

public interface ITransactionService
{
    public Task AddTransaction(
        Transaction transaction,
        CancellationToken cancellationToken);
    
    public Task<IReadOnlyList<Operation>> GetTransactionList(
        DateTime dateTimeFrom,
        DateTime dateTimeTo,
        CancellationToken cancellationToken);
    
    public Task<IReadOnlyList<Operation>> GetTransactionListForAccount(
        Account account,
        DateTime dateTimeFrom,
        DateTime dateTimeTo,
        CancellationToken cancellationToken);

    public Task EditTransaction(
        Transaction transaction,
        CancellationToken cancellationToken);

    public Task DeleteOperation(
        TransactionId transactionId,
        CancellationToken cancellationToken);
}
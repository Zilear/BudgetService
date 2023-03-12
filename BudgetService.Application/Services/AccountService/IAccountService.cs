using BudgetService.Domain.Entitiy;

namespace Application.Services.AccountService;

public interface IAccountService
{
    public Task CreateAccount(
        Account account,
        CancellationToken cancellationToken);

    public Task<IReadOnlyList<Account>> GetAccounts(
        CancellationToken cancellationToken);

    public Task<Account> EditAccount(
        Account account,
        CancellationToken cancellationToken);

    public Task DeleteAccount(
        Account account,
        CancellationToken cancellationToken);
}
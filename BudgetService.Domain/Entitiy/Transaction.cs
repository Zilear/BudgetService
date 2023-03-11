using BudgetService.Domain.ValueObjects;

namespace BudgetService.Domain.Entitiy;

public sealed record Transaction(
    TransactionId TransactionId,
    Account AccountFrom,
    Account AccountTo,
    double Amount);
using BudgetService.Domain.ValueObjects;

namespace BudgetService.Domain.Entitiy;

public sealed record Operation(
    OperationId OperationId,
    OperationType OperationType,
    DateTime Date,
    string Description,
    double Amount,
    CardId? CardId,
    bool IsCash);
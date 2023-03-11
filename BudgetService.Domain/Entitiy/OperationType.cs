using BudgetService.Domain.ValueObjects;

namespace BudgetService.Domain.Entitiy;

public sealed record OperationCategory(
    OperationId OperationId,
    string CategoryImageLink,
    OperationType OperationType);
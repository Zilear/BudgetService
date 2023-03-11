using BudgetService.Domain.ValueObjects;

namespace BudgetService.Domain.Entitiy;

public record Card(
    CardId CardId,
    string Name) : Account;
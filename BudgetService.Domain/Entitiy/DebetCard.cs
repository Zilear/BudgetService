using BudgetService.Domain.ValueObjects;

namespace BudgetService.Domain.Entitiy;

public sealed record DebetCard(
    long Amount,
    CardId CardId,
    string Name) : Card(
    CardId,
    Name);
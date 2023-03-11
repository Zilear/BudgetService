using BudgetService.Domain.ValueObjects;

namespace BudgetService.Domain.Entitiy;

public sealed record CreditCard(
    long InterestFreePeriod,
    DateTime InterestFreePeriodBeginning,
    long BillingPeriodDuration,
    long Limit,
    long Amount,
    CardId CardId,
    string Name) : Card(
    CardId,
    Name);
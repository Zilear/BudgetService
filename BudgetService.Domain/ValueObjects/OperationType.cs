namespace BudgetService.Domain.ValueObjects;

[Flags]
public enum OperationType
{
    Income = 1,
    Expense = 2
}
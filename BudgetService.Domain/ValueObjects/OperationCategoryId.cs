using BudgetService.Domain.Exceptions;

namespace BudgetService.Domain.ValueObjects;

public sealed record OperationCategoryId : IComparable<OperationCategoryId>
{
    private long Value { get; }

    private OperationCategoryId() { }

    private OperationCategoryId(long value)
    {
        if (value is < 0 or > long.MaxValue)
        {
            throw new DomainException($"Id операции не может быть меньше 0 или больше {long.MaxValue}");
        }

        Value = value;
    }

    public static OperationCategoryId Empty =>
        new();

    public static explicit operator OperationCategoryId(long operationId) =>
        new(operationId);

    public static implicit operator long(OperationCategoryId operationId) =>
        operationId.Value;

    public override string ToString() =>
        Value.ToString();

    public int CompareTo(OperationCategoryId other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;

        return Value.CompareTo(other.Value);
    }
}
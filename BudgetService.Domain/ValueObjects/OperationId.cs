using BudgetService.Domain.Exceptions;

namespace BudgetService.Domain.ValueObjects;

public sealed record OperationId : IComparable<OperationId>
{
    private long Value { get; }

    private OperationId() { }

    private OperationId(long value)
    {
        if (value is < 0 or > long.MaxValue)
        {
            throw new DomainException($"Id операции не может быть меньше 0 или больше {long.MaxValue}");
        }

        Value = value;
    }

    public static OperationId Empty =>
        new();

    public static explicit operator OperationId(long operationId) =>
        new(operationId);

    public static implicit operator long(OperationId operationId) =>
        operationId.Value;

    public override string ToString() =>
        Value.ToString();

    public int CompareTo(OperationId other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;

        return Value.CompareTo(other.Value);
    }
}
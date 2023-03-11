using BudgetService.Domain.Exceptions;

namespace BudgetService.Domain.ValueObjects;

public sealed record TransactionId : IComparable<TransactionId>
{
    private long Value { get; }

    private TransactionId()
    {
    }

    private TransactionId(long value)
    {
        if (value is < 0 or > long.MaxValue)
        {
            throw new DomainException($"Id карты не может быть меньше 0 или больше {long.MaxValue}");
        }

        Value = value;
    }

    public static TransactionId Empty =>
        new();

    public static explicit operator TransactionId(long transactionId) =>
        new(transactionId);

    public static implicit operator long(TransactionId transactionId) =>
        transactionId.Value;

    public override string ToString() =>
        Value.ToString();

    public int CompareTo(TransactionId other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;

        return Value.CompareTo(other.Value);
    }
}

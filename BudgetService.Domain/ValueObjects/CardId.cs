using BudgetService.Domain.Exceptions;

namespace BudgetService.Domain.ValueObjects;

public sealed record CardId : IComparable<CardId>
{
    private long Value { get; }

    private CardId() { }

    private CardId(long value)
    {
        if (value is < 0 or > long.MaxValue)
        {
            throw new DomainException($"Id карты не может быть меньше 0 или больше {long.MaxValue}");
        }

        Value = value;
    }

    public static CardId Empty =>
        new();

    public static explicit operator CardId(long cardId) =>
        new(cardId);

    public static implicit operator long(CardId cardId) =>
        cardId.Value;

    public override string ToString() =>
        Value.ToString();

    public int CompareTo(CardId other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;

        return Value.CompareTo(other.Value);
    }
}
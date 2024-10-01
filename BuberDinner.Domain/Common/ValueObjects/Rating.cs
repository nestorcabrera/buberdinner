using BuberDinner.Domain.Common.Models;

namespace BuberDinner.Domain.Common.ValueObjects;

public sealed class Rating : ValueObject
{
    public int Value { get; }
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
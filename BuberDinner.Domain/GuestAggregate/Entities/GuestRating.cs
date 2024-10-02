using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.GuestAggregate.ValuesObjects;

namespace BuberDinner.Domain.GuestAggregate.Entities;

public sealed class GuestRating : Entity<GuestRatingId>
{
    private GuestRating(GuestRatingId guestRatingId) : base(guestRatingId)
    {
    }
}
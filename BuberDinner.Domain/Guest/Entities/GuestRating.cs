using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Guest.ValuesObjects;

namespace BuberDinner.Domain.Guest.Entities;

public sealed class GuestRating : Entity<GuestRatingId>
{
    private GuestRating(GuestRatingId guestRatingId) : base(guestRatingId)
    {
    }
}
using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;

namespace BuberDinner.Domain.Dinner.Entities;

public sealed class Reservation : Entity<ReservationId>
{
    private Reservation(ReservationId reservationId) : base(reservationId)
    {
    }
}
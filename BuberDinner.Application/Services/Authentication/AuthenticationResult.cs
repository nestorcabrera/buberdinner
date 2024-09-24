using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authetication;

public record AutheticationResult(
    User User,
    string Token);
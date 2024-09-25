using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Services.Authetication;

public record AuthenticationResult(
    User User,
    string Token);
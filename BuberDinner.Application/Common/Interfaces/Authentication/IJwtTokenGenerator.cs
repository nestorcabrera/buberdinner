using BuberDinner.Domain.Entities;

namespace BuberDinner.Application.Common.Interface.Authetication;

public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
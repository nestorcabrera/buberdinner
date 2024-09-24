namespace BuberDinner.Application.Services.Authetication;

public interface IAuthenticationService
{
    AutheticationResult Login(
        string Email,
        string Password
    );
    AutheticationResult Register(
        string FirstName,
        string LastName,
        string Email,
        string Password
    );
}
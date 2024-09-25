using ErrorOr;
namespace BuberDinner.Application.Services.Authetication;

public interface IAuthenticationService
{
    ErrorOr<AuthenticationResult> Login(
        string Email,
        string Password
    );
    ErrorOr<AuthenticationResult> Register(
       string FirstName,
       string LastName,
       string Email,
       string Password
   );
}
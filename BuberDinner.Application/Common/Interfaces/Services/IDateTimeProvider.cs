namespace BuberDinner.Application.Common.Interface.Services;

public interface IDateTimeProvider
{
    DateTime UtcNow { get; }
}
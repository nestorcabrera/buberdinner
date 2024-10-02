using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.Common.ValueObjects;
using BuberDinner.Domain.DinnerAggregate.ValueObjects;
using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate.Entities;
using BuberDinner.Domain.MenuAggregate.ValueObjects;
using BuberDinner.Domain.MenuReviewAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate;

public sealed class Menu : AggregateRoot<MenuId>
{
    private readonly List<MenuSection> _sections = new();
    private readonly List<DinnerId> _dinnerIds = new();
    private readonly List<MenuReviewId> _menuReviewIds = new();
    public string Name { get; }
    public string Description { get; }
    public AverageRating AverageRating { get; }

    public IReadOnlyList<MenuSection> Setions => _sections.AsReadOnly();

    public HostId HostId { get; }

    public IReadOnlyList<DinnerId> DinnerIds => _dinnerIds.AsReadOnly();
    public IReadOnlyList<MenuReviewId> MenuReviewIds => _menuReviewIds.AsReadOnly();

    public DateTime CreatedDateTime { get; }
    public DateTime UpdatedDateTime { get; }

    private Menu(
        MenuId menuId,
        HostId hostId,
        string name,
        string description,
        AverageRating averageRating,
        List<MenuSection> sections,
        DateTime createdDateTime,
        DateTime updatedDateTime)
    : base(menuId)
    {
        Name = name;
        Description = description;
        HostId = hostId;
        AverageRating = averageRating;
        _sections = sections;
        CreatedDateTime = createdDateTime;
        UpdatedDateTime = updatedDateTime;
    }

    public static Menu Create(
        HostId hostId,
        string name,
        string description,
        List<MenuSection>? sections)
    {
        return new Menu(
            MenuId.CreateUnique(),
            hostId,
            name,
            description,
            AverageRating.CreateNew(),
            sections ?? new(),
            DateTime.UtcNow,
            DateTime.UtcNow);
    }
}
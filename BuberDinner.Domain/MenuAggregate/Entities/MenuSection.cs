using BuberDinner.Domain.Common.Models;
using BuberDinner.Domain.MenuAggregate.ValueObjects;

namespace BuberDinner.Domain.MenuAggregate.Entities;

public class MenuSection : Entity<MenuSectionId>
{
    private readonly List<MenuItem> _items = new();
    public string Name { get; }
    public string Description { get; }
    public IReadOnlyList<MenuItem> Items => _items.AsReadOnly();

    private MenuSection(
        MenuSectionId menuSectionId,
        string name,
        string description,
        List<MenuItem> items)
        : base(menuSectionId)
    {
        Name = name;
        Description = description;
        _items = items;
    }

    public static MenuSection Create(
        string name,
        string description,
        List<MenuItem>? items)
    {
        return new MenuSection(
            MenuSectionId.CreateUnique(),
            name,
            description,
            items ?? new());
    }

#pragma warning disable CS8618
    private MenuSection()
    {
    }
#pragma warning restore CS8618
}
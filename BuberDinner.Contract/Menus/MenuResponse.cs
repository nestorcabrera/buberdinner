namespace BuberDinner.Contract.Menus;

public record MenuResponse(
    string Id,
    string Name,
    string Description,
    float? AverageRation,
    List<MenuSection> Sections,
    string HostId,
    List<string> DinnerIds,
    List<string> MenuReviewIds,
    DateTime CreatedDateTime,
    DateTime UpdatedDateTime);

public record MenuSectionResponse(
    string Id,
    string Name,
    string Description,
    List<MenuItemResponse> Items);

public record MenuItemResponse(
    string Id,
    string Name,
    string Description);

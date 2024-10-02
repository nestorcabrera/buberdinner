using BuberDinner.Domain.HostAggregate.ValueObjects;
using BuberDinner.Domain.MenuAggregate;
using BuberDinner.Domain.MenuAggregate.Entities;

using ErrorOr;

using MediatR;

namespace BuberDinner.Application.Menus.Commands;

public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, ErrorOr<Menu>>
{
    public Task<ErrorOr<Menu>> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
    {
        // Create the menu
        var menu = Menu.Create(
            hostId: HostId.Create(request.HostId),
            name: request.Name,
            description: request.Description,
            sections: request.Sections.ConvertAll(s => MenuSection.Create(
                s.Name,
                s.Description,
                s.Items.ConvertAll(i => MenuItem.Create(
                    i.Name,
                    i.Description)).ToList())).ToList());

        // Persist the menu
        // Return the menu
        return default!;
    }
}
using BuberDinner.Application.Menus.Commands;
using BuberDinner.Contract.Menus;

using MapsterMapper;

using MediatR;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[Route("hosts/{hostId}/menus")]
public class MenuController : ApiController
{
    private readonly IMapper _mapper;
    private readonly ISender _sender;
    public MenuController(IMapper mapper, ISender sender)
    {
        _mapper = mapper;
        _sender = sender;
    }

    [AllowAnonymous]
    [HttpPost]
    public async Task<IActionResult> CreateMenu(
        CreateMenuRequest request,
        string hostId)
    {
        var command = _mapper.Map<CreateMenuCommand>((request, hostId));
        var createMenuCommand = await _sender.Send(command);

        return createMenuCommand.Match<IActionResult>(
            menu => Ok(_mapper.Map<MenuResponse>(menu)),
            errors => Problem(errors));
    }
}
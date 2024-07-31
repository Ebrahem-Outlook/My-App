using MediatR;
using Microsoft.AspNetCore.Mvc;
using My_App.API.Contracts.Users;
using My_App.Application.Users.Commands.CreateUser;

namespace My_App.API.Controllers;

[Route("api/[Controller]")]
[ApiController]
public sealed class UserController(ISender sender) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request)
    {
        await sender.Send(new CreateUserCommand(request.FirstName, request.LastName, request.Email, request.Passsword));
    }
      
}



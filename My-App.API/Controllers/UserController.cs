using MediatR;
using Microsoft.AspNetCore.Mvc;
using My_App.API.Contracts.Users;
using My_App.Application.Users.Commands.CreateUser;
using My_App.Application.Users.Commands.DeleteUser;
using My_App.Application.Users.Commands.UpdateUser;
using My_App.Application.Users.Queries.GetAll;
using My_App.Application.Users.Queries.GetByEmail;
using My_App.Application.Users.Queries.GetById;
using My_App.Application.Users.Queries.GetByName;

namespace My_App.API.Controllers;

[Route("[Controller]")]
[ApiController]
public sealed class UserController(ISender sender) : ControllerBase
{
    // Commands... 

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateUserRequest request) =>
        Ok(await sender.Send(
            new CreateUserCommand(
                request.FirstName,
                request.LastName, 
                request.Email,
                request.Passsword)));

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUserRequest request) =>
        Ok(await sender.Send(
            new UpdateUserCommand(
                request.UserId,
                request.FirstName,
                request.LastName)));

    [HttpDelete("id")]
    public async Task<IActionResult> Delete(Guid id) => Ok(await sender.Send(new DeleteUserCommand(id)));

    // Queries...

    [HttpGet]
    public async Task<IActionResult> GetAll() => Ok(await sender.Send(new GetAllUsersQuery()));

    [HttpGet("id")]
    public async Task<IActionResult> GetById(Guid id) => Ok(await sender.Send(new GetUserByIdQuery(id)));

    [HttpGet("email")]
    public async Task<IActionResult> GetByEmail(string email) => Ok(await sender.Send(new GetUserByEmailQuery(email)));

    [HttpGet("name")]
    public async Task<IActionResult> GetByName(string name) => Ok(await sender.Send(new GetUserByNameQuery(name)));
}



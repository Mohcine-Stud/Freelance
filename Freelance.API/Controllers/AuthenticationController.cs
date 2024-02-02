using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Queries.Login;
using Freelance.Application.ViewModels;
using Freelance.Application.ViewModels.Authentication;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.Application.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    private readonly ISender _mediator;
    private readonly IMapper _mapper;

    public AuthenticationController(ISender mediator, IMapper mapper)
    {
        _mediator = mediator;
        _mapper = mapper;
    }

    [HttpPost("register")]
    public async Task<ActionResult> Register(RegisterRequest request, string role)
    {
        // attributs validation
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var command = new RegisterCommand(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password,
            role
            );

        var response = await _mediator.Send(command);

        if (!response.ISAuthenticated)
        {
            return BadRequest(response.Message);
        }


        return Ok(response);
    }

    [HttpPost("login")]
    public async Task<ActionResult> Login(LoginQuery request)
    {
        // attributs validation
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var response = await _mediator.Send(request);

        if (!response.ISAuthenticated)
        {
            return BadRequest(response.Message);
        }

        return Ok(response);
    }
}

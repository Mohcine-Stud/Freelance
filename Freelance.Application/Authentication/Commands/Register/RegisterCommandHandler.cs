using Freelance.Application.Services.Authentication;
using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResponse>
{
    private readonly IAuthenticationService _authenticationservice;

    public RegisterCommandHandler(IAuthenticationService authenticationService)
    {
        _authenticationservice = authenticationService;
    }

    public async Task<AuthenticationResponse> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        var registerResult = await _authenticationservice.Register(command);

        return registerResult;
    }
}

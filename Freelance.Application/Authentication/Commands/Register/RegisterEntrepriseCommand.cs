using Freelance.Application.ViewModels.Authentication;
using MediatR;

namespace Freelance.Application.Authentication.Commands.Register;

public record RegisterEntrepriseCommand(
    string EntrepriseName,
    string Email,
    string Password,
    string Role) : IRequest<AuthenticationResponse>;

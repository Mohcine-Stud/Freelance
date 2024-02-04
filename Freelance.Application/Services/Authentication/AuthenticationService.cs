using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Common.Interfaces;
using Freelance.Application.Authentication.Queries.Login;
using Freelance.Application.ViewModels.Authentication;
using Freelance.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Data;


namespace Freelance.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IJwtTokenGenerator jwtTokenGenerator)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _jwtTokenGenerator = jwtTokenGenerator;
    }

    public async Task<AuthenticationResponse> Login(LoginQuery query)
    {
        var user = await _userManager.FindByEmailAsync(query.Email);

        if (user is null || !await _userManager.CheckPasswordAsync(user, query.Password))
        {
            return new AuthenticationResponse
            {
                Message = "Email or password is incorrect."
            };
        }

        var tokenParams = new GenerateTokenParams
        {
            FirstName = user.UserName,
            Email = user.Email,
        };

        //generate token
        var token = await _jwtTokenGenerator.GenerateToken(tokenParams);

        return new AuthenticationResponse
        {
            FirstName = user.UserName,
            LastName = user.UserName,
            Email = query.Email,
            ISAuthenticated = true,
            Token = token,
            Roles = (List<string>)await _userManager.GetRolesAsync(user)
        };

    }

    public async Task<AuthenticationResponse> RegisterEntreprise(RegisterEntrepriseCommand command)
    {
        var role = "ENTREPRISE";

        if (await _userManager.FindByEmailAsync(command.Email) is not null)
        {
            return new AuthenticationResponse
            {
                Message = " Entreprise Email is already used."
            };
        }

        var user = new IdentityUser
        {
            UserName = command.EntrepriseName,
            Email = command.Email,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        if (await _roleManager.RoleExistsAsync(role))
        {
            var result = await _userManager.CreateAsync(user, command.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, role);
            }
            else
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return new AuthenticationResponse
                {
                    Message = $"Entreprise account failed to create: {errors}",
                };
            }
        }
        else
        {
            return new AuthenticationResponse
            {
                Message = "This role doesn't exist!",
            };
        }

        //generate token
        var tokenParms = new GenerateTokenParams
        {
            UserType = "ENTREPRISE",
            FirstName = command.EntrepriseName,
            Email = user.Email,
        };

        var token = await _jwtTokenGenerator.GenerateToken(tokenParms);

        return new AuthenticationResponse
        {
            FirstName = command.EntrepriseName,
            Email = command.Email,
            ISAuthenticated = true,
            Token = token,
            Roles = (List<string>)await _userManager.GetRolesAsync(user)
        };
            

    }

    
}

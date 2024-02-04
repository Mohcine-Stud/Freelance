﻿using Freelance.Application.Authentication.Commands.Register;
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

        var applicationUser = new User
        {
            FirstName = user.UserName,
            Email = user.Email,

        };

        //generate token
        var token = await _jwtTokenGenerator.GenerateToken(applicationUser);

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

    public async Task<AuthenticationResponse> Register(RegisterCommand command)
    {

        if (await _userManager.FindByEmailAsync(command.Email) is not null)
        {
            return new AuthenticationResponse
            {
                Message = "Email is already used."
            };
        }

        var user = new IdentityUser
        {
            UserName = command.FirstName + "_"+ command.LastName,
            Email = command.Email,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        if (await _roleManager.RoleExistsAsync(command.Role))
        {
            var result = await _userManager.CreateAsync(user, command.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, command.Role);
            }
            else
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return new AuthenticationResponse
                {
                    Message = $"User failed to create: {errors}",
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
        var applicationUser = new User
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = user.Email,

        };
        var token = await _jwtTokenGenerator.GenerateToken(applicationUser);

        return new AuthenticationResponse
        {
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = command.Email,
            ISAuthenticated = true,
            Token = token,
            Roles = (List<string>)await _userManager.GetRolesAsync(user)
        };
            

    }

    
}
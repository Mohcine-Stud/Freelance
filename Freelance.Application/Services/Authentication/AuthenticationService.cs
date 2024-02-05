﻿using Freelance.Application.Authentication.Commands.Register;
using Freelance.Application.Authentication.Common.Interfaces;
using Freelance.Application.Authentication.Queries.Login;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.Services.Condidate.CondidatCompService;
using Freelance.Application.Services.Condidate.ExperienceService;
using Freelance.Application.Services.Condidate.FormationService;
using Freelance.Application.Services.Condidate.ProjetService;
using Freelance.Application.ViewModels.Authentication;
using Freelance.Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Data;
using static System.Formats.Asn1.AsnWriter;


namespace Freelance.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private readonly IGenericRepository<Candidat> _condidatRepository;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly ICandidateService _candidateService;
    private readonly IProjetService _projetService;
    private readonly IFormationService _formationService;
    private readonly IExperienceService _experienceService;
    private readonly ICondidatCompService _condidatCompService;



    public AuthenticationService(
        UserManager<IdentityUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IJwtTokenGenerator jwtTokenGenerator,
        IGenericRepository<Candidat> condidateRepository)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _jwtTokenGenerator = jwtTokenGenerator;
        _condidatRepository = condidateRepository;
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

    public async Task<AuthenticationResponse> RegisterCandidat(RegisterCanidatCommand command)
    {
        var role = "CANDIDAT";

        if (await _userManager.FindByEmailAsync(command.Email) is not null)
        {
            return new AuthenticationResponse
            {
                Message = " Candidat Email is already used."
            };
        }


        var user = new IdentityUser
        {
            UserName = command.FirstName + "_" + command.LastName,
            Email = command.Email,
            SecurityStamp = Guid.NewGuid().ToString()
        };

        //persist data to db 
        if (await _roleManager.RoleExistsAsync(role))
        {
            //create user
            var result = await _userManager.CreateAsync(user, command.Password);
    

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, role);

                // create candidat (mapping command to candidat to be fixed soon!)
                var candidat = new Candidat
                {
                    Titre = command.CandidatInfos.Titre,
                    Avatar = command.CandidatInfos.Avatar,
                    Gender = command.CandidatInfos.Gender,
                    Adresse = command.CandidatInfos.Adresse,
                    DateNaissance = command.CandidatInfos.DateNaissance,
                    Tele = command.CandidatInfos.Tele,
                    Mobilite = command.CandidatInfos.Mobilite,
                    Disponibilite = command.CandidatInfos.Disponibilite,
                    Ville = command.CandidatInfos.Ville,
                    CondidatComps = command.CompetenceList.ConvertAll(
                        competence => new CondidatComp
                        {
                            Niveau = competence.Niveau,
                            IdComp = competence.IdComp,
                        }),
                    Experiences = command.ExperienceList.ConvertAll(
                        experience => new Experience
                        {
                            Titre = experience.Titre,
                            Local = experience.Local,
                            Description = experience.Description,
                            Ville = experience.Ville,
                            DateDebut = experience.DateDebut,
                            DateFin = experience.DateFin
                        }),
                    Formations = command.FormationList.ConvertAll(
                        formation => new Formation
                        {
                            Niveau = formation.Niveau,
                            Ecole = formation.Ecole,
                            Diplome = formation.Diplome,
                            Description = formation.Description,
                            Ville = formation.Ville,
                            DateDebut = formation.DateDebut,
                            DateFin = formation.DateFin
                         }),
                    Projets = command.ProjetList.ConvertAll(
                        projet => new Projet
                        {
                            Nom = projet.Nom,
                            Description = projet.Description,
                            Link = projet.Link
                        })
                };

                //persist candidat to db
                await _condidatRepository.PostAsync(candidat);
                
            }
            else
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                return new AuthenticationResponse
                {
                    Message = $"Candidat account failed to create: {errors}",
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
            UserType = "CANDIDAT",
            FirstName = command.FirstName,
            LastName = command.LastName,
            Email = user.Email,
        };

        var token = await _jwtTokenGenerator.GenerateToken(tokenParms);

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

    public async Task<AuthenticationResponse> RegisterEntreprise(RegisterEnrepriseCommand command)
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

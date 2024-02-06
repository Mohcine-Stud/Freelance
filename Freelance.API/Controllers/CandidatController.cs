using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CandidatController : ControllerBase
{
    private readonly ICandidateService _condidateService;
    public CandidatController(ICandidateService condidateService)
    {
        _condidateService = condidateService;
    }


    //[HttpGet("{id}")]
    //public async Task<IActionResult> GetById(int id)
    //{
    //    var condidatDTO = await _condidateService.FindByIdAsync(id);

    //    if (condidatDTO == null)
    //    {
    //        return NotFound();
    //    }

    //    return Ok(condidatDTO);
    //}

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var candidat = await _condidateService.GetCandidatWithDetailsAsync(id);

        if (candidat == null)
            return NotFound();

        var candidatDto = new CandidatDTO
        {
            Id = candidat.Id,
            FirstName = candidat.FirstName,
            // Map other properties

            CondidatComps = candidat.CondidatComps.Select(c => new CondidatCompGetDTO
            {
                Id = c.Id,
                Niveau = c.Niveau,
                // Map other properties
            }).ToList(),

            Experiences = candidat.Experiences.Select(e => new ExperienceGetDTO
            {
                Id = e.Id,
                Titre = e.Titre,
                // Map other properties
            }).ToList(),

            Formations = candidat.Formations.Select(f => new FormationGetDTO
            {
                Id = f.Id,
                Niveau = f.Niveau,
                // Map other properties
            }).ToList(),

            Projets = candidat.Projets.Select(p => new ProjetGetDTO
            {
                Id = p.Id,
                Nom = p.Nom,
                // Map other properties
            }).ToList(),
        };

        return Ok(candidatDto);
    }

    [HttpGet]
    public async Task<ActionResult<List<CandidatDTO>>> GetAll()
    {
        var candidats = await _condidateService.GetAllCandidatsWithDetailsAsync();

        var candidatDtos = candidats.Select(c => new CandidatDTO
        {
            Id = c.Id,
            FirstName = c.FirstName,
            // Map other properties

            CondidatComps = c.CondidatComps.Select(cc => new CondidatCompGetDTO
            {
                Id = cc.Id,
                Niveau = cc.Niveau,
                // Map other properties
            }).ToList(),

            Experiences = c.Experiences.Select(e => new ExperienceGetDTO
            {
                Id = e.Id,
                Titre = e.Titre,
                // Map other properties
            }).ToList(),

            Formations = c.Formations.Select(f => new FormationGetDTO
            {
                Id = f.Id,
                Niveau = f.Niveau,
                // Map other properties
            }).ToList(),

            Projets = c.Projets.Select(p => new ProjetGetDTO
            {
                Id = p.Id,
                Nom = p.Nom,
                // Map other properties
            }).ToList(),
        }).ToList();

        return Ok(candidatDtos);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CandidatCreateDTO addPartnerDto)
    {
        var createCondidatDTO = await _condidateService.CreateAsync(addPartnerDto);
        return CreatedAtAction(nameof(GetById), new { id = createCondidatDTO.Id }, createCondidatDTO);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] CandidatUpdateDTO updatePartnerDto)
    {
        var updateCondidatDTO = await _condidateService.UpdateAsync(id, updatePartnerDto);

        if (updateCondidatDTO == null)
        {
            return NotFound();
        }

        return Ok(updateCondidatDTO);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _condidateService.DeleteAsync(id);
        return NoContent();
    }
}
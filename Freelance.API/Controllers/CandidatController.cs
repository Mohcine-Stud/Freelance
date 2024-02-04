using Freelance.Application.Services.Condidate.CandidatService;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
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


    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var condidatDTO = await _condidateService.FindByIdAsync(id);

        if (condidatDTO == null)
        {
            return NotFound();
        }

        return Ok(condidatDTO);
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var condidatDTO = await _condidateService.FindAllAsync();
        return Ok(condidatDTO);
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
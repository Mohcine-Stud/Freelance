using Freelance.Application.Services.Condidate.Candidat;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Freelance.API.Controllers
{
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
            var partnerDto = await _condidateService.FindByIdAsync(id);

            if (partnerDto == null)
            {
                return NotFound();
            }

            return Ok(partnerDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var partnerDtos = await _condidateService.FindAllAsync();
            return Ok(partnerDtos);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CandidatCreateDTO addPartnerDto)
        {
            var createdPartnerDto = await _condidateService.CreateAsync(addPartnerDto);
            return CreatedAtAction(nameof(GetById), new { id = createdPartnerDto.Id }, createdPartnerDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] CandidatUpdateDTO updatePartnerDto)
        {
            var updatedPartnerDto = await _condidateService.UpdateAsync(id, updatePartnerDto);

            if (updatedPartnerDto == null)
            {
                return NotFound();
            }

            return Ok(updatedPartnerDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _condidateService.DeleteAsync(id);
            return NoContent();
        }
    }

}
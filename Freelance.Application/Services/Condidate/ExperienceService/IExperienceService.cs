using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ExperienceService;

public interface IExperienceService
{
    Task<ExperienceDTO> FindByIdAsync(int id);
    Task<List<ExperienceDTO>> FindAllAsync();
    Task<ExperienceDTO> CreateAsync(ExperienceCreateDTO entity);
    Task<ExperienceDTO> UpdateAsync(int id, ExperienceUpdateDTO entity);
    Task DeleteAsync(int id);
}

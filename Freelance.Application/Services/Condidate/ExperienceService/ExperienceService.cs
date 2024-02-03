using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ExperienceService;

internal class ExperienceService : IExperienceService
{
    public Task<ExperienceDTO> CreateAsync(ExperienceCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<ExperienceDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<ExperienceDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<ExperienceDTO> UpdateAsync(int id, ExperienceUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CompetenceService;

internal class CompetenceService : ICompetenceService
{
    public Task<CompetenceDTO> CreateAsync(CompetenceCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<CompetenceDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CompetenceDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CompetenceDTO> UpdateAsync(int id, CompetenceUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

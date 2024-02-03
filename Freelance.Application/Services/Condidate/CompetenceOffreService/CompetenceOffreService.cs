using Freelance.Application.ViewModels.DTOs.CompetenceOffreDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CompetenceOffreService;

internal class CompetenceOffreService : ICompetenceOffreSevice
{
    public Task<CompetenceOffreDTO> CreateAsync(CompetenceOffreCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<CompetenceOffreDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CompetenceOffreDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CompetenceOffreDTO> UpdateAsync(int id, CompetenceOffreUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

using Freelance.Application.Services.Condidate.Candidat;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class CandidatService : ICondidateService
{
    public Task<CandidatDTO> CreateAsync(CandidatCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<CandidatDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CandidatDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<CandidatDTO> UpdateAsync(int id, CandidatUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.FormationService;

public class FormationService : IFormationService
{
    private readonly IFormationService _formationService;
    public FormationService(IFormationService formationService)
    {
            
    }
    public Task<FormationDTO> CreateAsync(FormationCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<FormationDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<FormationDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<FormationDTO> UpdateAsync(int id, FormationUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

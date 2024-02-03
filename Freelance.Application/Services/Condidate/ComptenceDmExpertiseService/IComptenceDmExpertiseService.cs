using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ComptenceDmExpertiseService;

internal interface IComptenceDmExpertiseService
{
    Task<ComptenceDmExpertiseDTO> FindByIdAsync(int id);
    Task<List<ComptenceDmExpertiseDTO>> FindAllAsync();
    Task<ComptenceDmExpertiseDTO> CreateAsync(ComptenceDmExpertiseCreateDTO entity);
    Task<ComptenceDmExpertiseDTO> UpdateAsync(int id, ComptenceDmExpertiseUpdateDTO entity);
    Task DeleteAsync(int id);
}

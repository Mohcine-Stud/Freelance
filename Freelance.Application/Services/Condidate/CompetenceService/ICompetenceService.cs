using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CompetenceService
{
    public interface ICompetenceService
    {
        Task<CompetenceExpetiseDTO> FindByIdAsync(int id);
        Task<List<CompetenceExpetiseDTO>> FindAllAsync();
        Task<CompetenceExpetiseDTO> CreateAsync(CompetenceCreateDTO entity);
        Task<CompetenceExpetiseDTO> UpdateAsync(int id, CompetenceUpdateDTO entity);
        Task DeleteAsync(int id);
    }
}

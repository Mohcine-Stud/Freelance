using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CompetenceService
{
    public interface ICompetenceService
    {
        Task<CompetenceDTO> FindByIdAsync(int id);
        Task<List<CompetenceDTO>> FindAllAsync();
        Task<CompetenceDTO> CreateAsync(CompetenceCreateDTO entity);
        Task<CompetenceDTO> UpdateAsync(int id, CompetenceUpdateDTO entity);
        Task DeleteAsync(int id);
    }
}

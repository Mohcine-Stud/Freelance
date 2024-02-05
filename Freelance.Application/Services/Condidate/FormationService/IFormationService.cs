using Freelance.Application.ViewModels.DTOs.FormationDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.FormationService;

public interface IFormationService
{
    Task<FormationDTO> FindByIdAsync(int id);
    Task<List<FormationDTO>> FindAllAsync();
    Task<FormationDTO> CreateAsync(FormationCreateDTO entity);
    Task<FormationDTO> UpdateAsync(int id, FormationUpdateDTO entity);
    Task DeleteAsync(int id);
}

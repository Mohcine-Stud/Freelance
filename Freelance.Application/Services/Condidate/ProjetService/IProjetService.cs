using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ProjetService;

public interface IProjetService
{
    Task<ProjetDTO> FindByIdAsync(int id);
    Task<List<ProjetDTO>> FindAllAsync();
    Task<ProjetDTO> CreateAsync(ProjetCreateDTO entity);
    Task<ProjetDTO> UpdateAsync(int id, ProjetUpdateDTO entity);
    Task DeleteAsync(int id);
}

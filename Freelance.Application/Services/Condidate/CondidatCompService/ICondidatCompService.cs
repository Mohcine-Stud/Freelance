using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CondidatCompService
{
    public interface ICondidatCompService
    {
        Task<CondidatCompDTO> FindByIdAsync(int id);
        Task<List<CondidatCompDTO>> FindAllAsync();
        Task<CondidatCompDTO> CreateAsync(CondidatCompCreateDTO entity);
        Task<CondidatCompDTO> UpdateAsync(int id, CondidatCompUpdateDTO entity);
        Task DeleteAsync(int id);
    }
}

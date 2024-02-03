using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.CondidatCompService
{
    internal class CondidatCompService : ICondidatCompService
    {
        public Task<CondidatCompDTO> CreateAsync(CondidatCompCreateDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<CondidatCompDTO>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CondidatCompDTO> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<CondidatCompDTO> UpdateAsync(int id, CondidatCompUpdateDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

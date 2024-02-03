using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ProjetService
{
    internal class ProjetService : IProjetService
    {
        public Task<ProjetDTO> CreateAsync(ProjetCreateDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProjetDTO>> FindAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProjetDTO> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ProjetDTO> UpdateAsync(int id, ProjetUpdateDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}

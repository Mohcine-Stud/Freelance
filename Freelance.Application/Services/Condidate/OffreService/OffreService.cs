using Freelance.Application.ViewModels.DTOs.OffreDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.OffreService;

internal class OffreService : IOffreService
{
    public Task<OffreDTO> CreateAsync(OffreCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<OffreDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<OffreDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<OffreDTO> UpdateAsync(int id, OffreUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

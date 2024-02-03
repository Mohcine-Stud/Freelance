using Freelance.Application.ViewModels.DTOs.MessagerieDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.MessagerieService;

internal class MessagerieService : IMessagerieService
{
    public Task<MessagerieDTO> CreateAsync(MessagerieCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<MessagerieDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<MessagerieDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<MessagerieDTO> UpdateAsync(int id, MessagerieUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

using Freelance.Application.ViewModels.DTOs.EntrepriseDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Entreprise.EntrepriseService;

public class EntrepriseService : IEntrepriseService
{
    public Task<EntrepriseDTO> CreateAsync(EntrepriseCreateDTO entity)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<List<EntrepriseDTO>> FindAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<EntrepriseDTO> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<EntrepriseDTO> UpdateAsync(int id, EntrepriseUpdateDTO entity)
    {
        throw new NotImplementedException();
    }
}

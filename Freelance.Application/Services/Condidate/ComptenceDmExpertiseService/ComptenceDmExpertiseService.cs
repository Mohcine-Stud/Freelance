using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CompeteceDmExpertiseDTO;
using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.ComptenceDmExpertiseService;

public class ComptenceDmExpertiseService
{
    private readonly IGenericRepository<CompetenceDmExpertise> _competenceDmExpertiseRepository;
    private readonly IMapper _mapper;

    public ComptenceDmExpertiseService(IGenericRepository<CompetenceDmExpertise> competenceDmExpertiseRepository, IMapper mapper)
    {
        _competenceDmExpertiseRepository = competenceDmExpertiseRepository;
        _mapper = mapper;
    }


    //public async Task<CompetenceDmExpetiseDTO> FindByIdAsync(int id)
    //{
    //    var competenceDmExpertise = await _competenceDmExpertiseRepository.GetAsync(id);
    //    return _mapper.Map<CompetenceDmExpetiseDTO>(competenceDmExpertise);
    //}

    //public async Task<List<CompetenceDmExpetiseDTO>> FindAllAsync()
    //{
    //    var competenceDmExpertise = await _competenceDmExpertiseRepository.GetAllAsync();
    //    return _mapper.Map<List<CompetenceDmExpetiseDTO>>(competenceDmExpertise);
    //}

    //public async Task<CompetenceDmExpetiseDTO> CreateAsync(ComptenceDmExpertiseCreateDTO entity)
    //{
    //    var competenceDmExpertise = _mapper.Map<CompetenceDmExpertise>(entity);
    //    var createdcompetenceDm = await _competenceDmExpertiseRepository.PostAsync(competenceDmExpertise);
    //    return _mapper.Map<CompetenceDmExpetiseDTO>(createdcompetenceDm);
    //}

    //public async Task<CompetenceDmExpetiseDTO> UpdateAsync(int id, ComptenceDmExpertiseUpdateDTO entity)
    //{
    //    var existingcompetenceDm = await _competenceDmExpertiseRepository.GetAsync(id);
    //    if (existingcompetenceDm == null)
    //        return null;

    //    _mapper.Map(entity, existingcompetenceDm);
    //    await _competenceDmExpertiseRepository.PutAsync(id, existingcompetenceDm);
    //    return _mapper.Map<CompetenceDmExpetiseDTO>(existingcompetenceDm);
    //}

    //public async Task DeleteAsync(int id)
    //{
    //    var existingcompetenceDm = await _competenceDmExpertiseRepository.GetAsync(id);
    //    if (existingcompetenceDm == null)
    //        return;
    //    await _competenceDmExpertiseRepository.DeleteAsync(id);
    //}


}

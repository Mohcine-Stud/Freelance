using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CondidateDTO;
using Freelance.Application.ViewModels.DTOs.ExperienceDTO;
using Freelance.Application.ViewModels.DTOs.FormationDTO;
using Freelance.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freelance.Application.Services.Condidate.FormationService;

public class FormationService : IFormationService
{
    private readonly IGenericRepository<Formation> _formationRepository;
    private readonly IMapper _mapper;

    public FormationService(IGenericRepository<Formation> formationRepository, IMapper mapper)
    {
        _formationRepository = formationRepository;
        _mapper = mapper;
    }

    public async Task<FormationDTO> CreateAsync(FormationCreateDTO entity)
    {
        var Formation = _mapper.Map<Formation>(entity);
        var createdFormation = await _formationRepository.PostAsync(Formation);
        return _mapper.Map<FormationDTO>(createdFormation);
    }



    public async Task<List<FormationDTO>> FindAllAsync()
    {
        var candidat = await _formationRepository.GetAllAsync();
        return _mapper.Map<List<FormationDTO>>(candidat);
    }

    public async Task<FormationDTO> FindByIdAsync(int id)
    {
        var candidat = await _formationRepository.GetAsync(id);
        return _mapper.Map<FormationDTO>(candidat);
    }

    public async Task<FormationDTO> UpdateAsync(int id, FormationUpdateDTO entity)
    {
        var existingCandidat = await _formationRepository.GetAsync(id);
        if (existingCandidat == null)
            return null;

        _mapper.Map(entity, existingCandidat);
        await _formationRepository.PutAsync(id, existingCandidat);
        return _mapper.Map<FormationDTO>(existingCandidat);
    }

    public async Task DeleteAsync(int id)
    {
        var existingCandidat = await _formationRepository.GetAsync(id);
        if (existingCandidat == null)
            return;
        await _formationRepository.DeleteAsync(id);
    }

    public async Task<IEnumerable<FormationDTO>> CreateRangeAsync(IEnumerable<FormationCreateDTO> entities)
    {
        var Entities = _mapper.Map<IEnumerable<Formation>>(entities);
        var createdEntity = await _formationRepository.PostRangeAsync(Entities);
        return _mapper.Map<IEnumerable<FormationDTO>>(createdEntity);
    }
}

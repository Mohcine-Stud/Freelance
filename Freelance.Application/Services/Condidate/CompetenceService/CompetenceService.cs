using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CompetenceDTO;
using Freelance.Domain.Models;

namespace Freelance.Application.Services.Condidate.CompetenceService;

internal class CompetenceService : ICompetenceService
{
    readonly IGenericRepository<CompetenceDmExpertise> _competenceRepository;
    private readonly IMapper _mapper;

    public CompetenceService(IGenericRepository<CompetenceDmExpertise> competenceRepository, IMapper mapper)
    {
        _competenceRepository = competenceRepository;
        _mapper = mapper;
    }


    public async Task<CompetenceDmExpetiseDTO> FindByIdAsync(int id)
    {
        var competence = await _competenceRepository.GetAsync(id);
        return _mapper.Map<CompetenceDmExpetiseDTO>(competence);
    }

    public async Task<List<CompetenceDmExpetiseDTO>> FindAllAsync()
    {
        var competence = await _competenceRepository.GetAllAsync();
        return _mapper.Map<List<CompetenceDmExpetiseDTO>>(competence);
    }

    public async Task<CompetenceDmExpetiseDTO> CreateAsync(CompetenceCreateDTO entity)
    {
        var competence = _mapper.Map<CompetenceDmExpertise>(entity);
        var createdcompetence = await _competenceRepository.PostAsync(competence);
        return _mapper.Map<CompetenceDmExpetiseDTO>(createdcompetence);
    }

    public async Task<CompetenceDmExpetiseDTO> UpdateAsync(int id, CompetenceUpdateDTO entity)
    {
        var existingcompetence = await _competenceRepository.GetAsync(id);
        if (existingcompetence == null)
            return null;

        _mapper.Map(entity, existingcompetence);
        await _competenceRepository.PutAsync(id, existingcompetence);
        return _mapper.Map<CompetenceDmExpetiseDTO>(existingcompetence);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetence = await _competenceRepository.GetAsync(id);
        if (existingcompetence == null)
            return;
        await _competenceRepository.DeleteAsync(id);
    }
}

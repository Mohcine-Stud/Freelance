using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.ProjetDTO;
using Freelance.Domain.Models;


namespace Freelance.Application.Services.Condidate.ProjetService
{
    internal class ProjetService : IProjetService
    {
        readonly IGenericRepository<Projet> _projectService;
        private readonly IMapper _mapper;

        public ProjetService(IGenericRepository<Projet> projectService, IMapper mapper)
        {
            _mapper = mapper;
            _projectService = projectService;
        }

        public async Task<ProjetDTO> CreateAsync(ProjetCreateDTO entity)
        {
            var competenceDmExpertise = _mapper.Map<Projet>(entity);
            var createdcompetenceDm = await _projectService.PostAsync(competenceDmExpertise);
            return _mapper.Map<ProjetDTO>(createdcompetenceDm);
        }

        public async Task DeleteAsync(int id)
        {
            var existingcompetenceDm = await _projectService.GetAsync(id);
            if (existingcompetenceDm == null)
                return;
            await _projectService.DeleteAsync(id);
        }

        public async Task<List<ProjetDTO>> FindAllAsync()
        {
            var competenceDmExpertise = await _projectService.GetAllAsync();
            return _mapper.Map<List<ProjetDTO>>(competenceDmExpertise);
        }

        public async Task<ProjetDTO> FindByIdAsync(int id)
        {
            var competenceDmExpertise = await _projectService.GetAsync(id);
            return _mapper.Map<ProjetDTO>(competenceDmExpertise);
        }

        public async Task<ProjetDTO> UpdateAsync(int id, ProjetUpdateDTO entity)
        {
            var existingcompetenceDm = await _projectService.GetAsync(id);
            if (existingcompetenceDm == null)
                return null;

            _mapper.Map(entity, existingcompetenceDm);
            await _projectService.PutAsync(id, existingcompetenceDm);
            return _mapper.Map<ProjetDTO>(existingcompetenceDm);
        }

        public async Task<IEnumerable<ProjetDTO>> CreateRangeAsync(IEnumerable<ProjetCreateDTO> entities)
        {
            var Entities = _mapper.Map<IEnumerable<Projet>>(entities);
            var createdEntity = await _projectService.PostRangeAsync(Entities);
            return _mapper.Map<IEnumerable<ProjetDTO>>(createdEntity);
        }
    }
}

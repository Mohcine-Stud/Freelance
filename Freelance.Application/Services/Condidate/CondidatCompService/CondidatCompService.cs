using AutoMapper;
using Freelance.Application.Persistence.IRepositories;
using Freelance.Application.ViewModels.DTOs.CondidatCompDTO;
using Freelance.Domain.Models;


namespace Freelance.Application.Services.Condidate.CondidatCompService;

public class CondidatCompService : ICondidatCompService
{
    readonly IGenericRepository<CondidatComp> _condidatComp;
    private readonly IMapper _mapper;

    public CondidatCompService(IGenericRepository<CondidatComp> condidatComp, IMapper mapper)
    {
        _mapper = mapper;
        _condidatComp = condidatComp;
    }

    public async Task<CondidatCompDTO> CreateAsync(CondidatCompCreateDTO entity)
    {
        var competenceDmExpertise = _mapper.Map<CondidatComp>(entity);
        var createdcompetenceDm = await _condidatComp.PostAsync(competenceDmExpertise);
        return _mapper.Map<CondidatCompDTO>(createdcompetenceDm);
    }

    public async Task DeleteAsync(int id)
    {
        var existingcompetenceDm = await _condidatComp.GetAsync(id);
        if (existingcompetenceDm == null)
            return;
        await _condidatComp.DeleteAsync(id);
    }

    public async Task<List<CondidatCompDTO>> FindAllAsync()
    {
        var competenceDmExpertise = await _condidatComp.GetAllAsync();
        return _mapper.Map<List<CondidatCompDTO>>(competenceDmExpertise);
    }

    public async Task<CondidatCompDTO> FindByIdAsync(int id)
    {
        var competenceDmExpertise = await _condidatComp.GetAsync(id);
        return _mapper.Map<CondidatCompDTO>(competenceDmExpertise);
    }

    public async Task<CondidatCompDTO> UpdateAsync(int id, CondidatCompUpdateDTO entity)
    {
        var existingcompetenceDm = await _condidatComp.GetAsync(id);
        if (existingcompetenceDm == null)
            return null;

        _mapper.Map(entity, existingcompetenceDm);
        await _condidatComp.PutAsync(id, existingcompetenceDm);
        return _mapper.Map<CondidatCompDTO>(existingcompetenceDm);
    }
}

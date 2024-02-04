using Freelance.Application.ViewModels.DTOs.CondidateDTO;

namespace Freelance.Application.Services.Condidate.Candidat;

public interface ICandidateService
{
    Task<CandidatDTO> FindByIdAsync(int id);
    Task<List<CandidatDTO>> FindAllAsync();
    Task<CandidatDTO> CreateAsync(CandidatCreateDTO entity);
    Task<CandidatDTO> UpdateAsync(int id, CandidatUpdateDTO entity);
    Task DeleteAsync(int id);
}

using CRAms.Data.DTOs.Read;
using CRAms.Data.Models;

namespace CRAms.Data.Interfaces
{
    public interface ITechnicalGuidelineService
    {
        public Task<TechnicalGuideline> AddParentRequirementAsync(TechnicalGuideline technicalGuideline, Requirement requirement);
        public Task<TechnicalGuideline> CreateTechnicalGuidelineAsync(string languageName, string version, ICollection<Requirement> parentRequirements);
        public Task<TechnicalGuidelineDto?> GetCurrentTechnicalGuidelineAsync(string languageName);
        public Task<TechnicalGuideline?> GetTechnicalGuidelineAsync(string languageName, string version);
    }
}

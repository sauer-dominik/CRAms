namespace CRAms.Data.DTOs.Write
{
    public class CreateTechnicalGuidelineDto
    {
        required public string LanguageName { get; set; }
        public ICollection<CreateRequirementDto> ParentRequirements { get; set; } = new List<CreateRequirementDto>();
        required public string Version { get; set; }
    }
}

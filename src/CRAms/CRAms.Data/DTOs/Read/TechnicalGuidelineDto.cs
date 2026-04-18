namespace CRAms.Data.DTOs.Read
{
    public class TechnicalGuidelineDto : EntityDto
    {
        required public IEnumerable<RequirementDto> Requirements { get; set; }
        required public string Version { get; set; }
    }
}

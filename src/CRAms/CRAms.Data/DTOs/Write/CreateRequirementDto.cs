namespace CRAms.Data.DTOs.Write
{
    public class CreateRequirementDto
    {
        required public string Name { get; set; }
        public ICollection<CreateItemDto> RequirementItems { get; set; } = new List<CreateItemDto>();
        public ICollection<CreateRequirementDto> SubRequirements { get; set; } = new List<CreateRequirementDto>();
    }
}

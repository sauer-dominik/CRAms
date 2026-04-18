namespace CRAms.Data.DTOs.Read
{
    public class RequirementDto : NamedEntityDto
    {
        public bool IsParent { get; set; }
        required public ICollection<ItemDto> RequirementItems { get; set; }
        public ICollection<RequirementDto>? SubRequirements { get; set; }
    }
}

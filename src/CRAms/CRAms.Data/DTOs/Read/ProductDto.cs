namespace CRAms.Data.DTOs.Read
{
    public class ProductDto : NamedEntityDto
    {
        required public IEnumerable<ItemTaskDto> ItemTasks { get; set; }
        required public Guid TechnicalGuidelineId { get; set; }
    }
}

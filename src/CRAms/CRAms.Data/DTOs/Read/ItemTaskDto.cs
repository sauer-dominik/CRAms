namespace CRAms.Data.DTOs.Read
{
    public class ItemTaskDto : EntityDto
    {
        public bool IsApplicable { get; set; }
        public bool IsCompleted { get; set; }
        required public Guid ItemId { get; set; }
        required public Guid RequirementId { get; set; }
    }
}

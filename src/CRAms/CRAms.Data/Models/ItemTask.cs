namespace CRAms.Data.Models
{
    public class ItemTask : Entity
    {
        public bool IsApplicable { get; set; } = true;
        public bool IsCompleted { get; set; }

        public Item? Item { get; set; }
        required public Guid ItemId { get; set; }

        public Requirement? Requirement { get; set; }
        required public Guid RequirementId { get; set; }
    }
}

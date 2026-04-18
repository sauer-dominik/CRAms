namespace CRAms.Data.Models
{
    public class Requirement : NamedEntity
    {
        public Requirement? ParentRequirement { get; set; }
        public Guid? ParentRequirementId { get; set; }
        public ICollection<Item> RequirementItems { get; set; } = new List<Item>();
        public ICollection<Requirement> SubRequirements { get; set; } = new List<Requirement>();
        public TechnicalGuideline? TechnicalGuideline { get; set; }
        required public Guid TechnicalGuidelineId { get; set; }
    }
}

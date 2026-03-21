namespace CRAms.API.Data.Models
{
    public class RequirementGroup : NamedEntity
    {
        /// <summary>
        /// The elements this RequirementGroup consists of:
        /// Assessments, Conditions and Requirements as described by BSI TR-03183.
        /// </summary>
        public ICollection<Item> Items { get; set; } = new List<Item>();
        /// <summary>
        /// Navigation-Property of the TechnicalGuideline this RequirementGroup belongs to.
        /// </summary>
        public TechnicalGuideline? TechnicalGuideline { get; set; }
        /// <summary>
        /// Id of the TechnicalGuideline this RequirementGroup belongs to.
        /// </summary>
        required public Guid TechnicalGuidelineId { get; set; }
    }
}

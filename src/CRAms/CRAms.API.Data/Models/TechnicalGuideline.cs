namespace CRAms.API.Data.Models
{
    public class TechnicalGuideline : Entity
    {
        /// <summary>
        /// The Version of BSI TR-03183 this Requirements apply to.
        /// String will be use since SemVer cannot be assumed.
        /// </summary>
        required public string Version { get; set; }

        /// <summary>
        /// The Groupings of Requirements (Headings) as described in BSI TR-03183.
        /// </summary>
        public ICollection<RequirementGroup> RequirementGroups { get; set; } = new List<RequirementGroup>();
    }
}

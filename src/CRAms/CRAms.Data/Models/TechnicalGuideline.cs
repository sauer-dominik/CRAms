namespace CRAms.Data.Models
{
    public class TechnicalGuideline : Entity
    {
        required public DateTime CreatedAt { get; set; }
        /// <summary>
        /// The Language of the Technical Guideline.
        /// </summary>
        required public string LanguageName { get; set; }
        /*
        /// <summary>
        /// The Groupings of Requirements (Headings) as described in BSI TR-03183.
        /// </summary>
        public ICollection<RequirementGroup> RequirementGroups { get; set; } = new List<RequirementGroup>();
        */
        /// <summary>
        /// The Requirements as described in BSI TR-03183.
        /// </summary>
        public ICollection<Requirement> ParentRequirements { get; set; } = new List<Requirement>();
        /// <summary>
        /// The Version of BSI TR-03183 this Requirements apply to.
        /// String will be used since SemVer cannot be assumed.
        /// </summary>
        required public string Version { get; set; }
    }
}

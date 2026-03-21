using CRAms.API.Data.Enums;

namespace CRAms.API.Data.Models
{
    public class Item : Entity
    {
        /// <summary>
        /// The description of what to do regarding this Item.
        /// </summary>
        required public string Description { get; set; }
        /// <summary>
        /// Navigation-Property of the RequirementGroup this Item belongs to.
        /// </summary>
        public RequirementGroup? RequirementGroup { get; set; }
        /// <summary>
        /// The Id of the RequirementGroup this Item belongs to.
        /// </summary>
        required public Guid RequirementGroupId { get; set; }
        /// <summary>
        /// The Type of this Item, see <see cref="ItemType"/>.
        /// </summary>
        required public ItemType Type { get; set; }
    }
}

using CRAms.Data.Enums;

namespace CRAms.Data.Models
{
    public class Item : Entity
    {
        /// <summary>
        /// The description of what to do regarding this Item.
        /// </summary>
        required public string Description { get; set; }
        /// <summary>
        /// Navigation-Property of the Rqeuirement this Item belongs to.
        /// </summary>
        public Requirement? Requirement { get; set; }
        /// <summary>
        /// The Id of the Requirement this Item belongs to.
        /// </summary>
        required public Guid RequirementId { get; set; }
        /// <summary>
        /// The Type of this Item, see <see cref="ItemType"/>.
        /// </summary>
        required public ItemType Type { get; set; }
    }
}

namespace CRAms.Data.Models
{
    public abstract class NamedEntity : Entity
    {
        /// <summary>
        /// Name or Label of the Entity.
        /// </summary>
        required public string Name { get; set; }
        /// <summary>
        /// Optional Description of the Entity.
        /// </summary>
        public string? Description { get; set; }
    }
}

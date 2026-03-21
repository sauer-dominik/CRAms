namespace CRAms.API.Data.Models
{
    public abstract class Entity
    {
        /// <summary>
        /// Unique-Identifier of this Entity.
        /// </summary>
        required public Guid Id { get; set; }
    }
}

namespace CRAms.Data.DTOs.Read
{
    public abstract class NamedEntityDto
    {
        required public Guid Id { get; set; }
        public string? Description { get; set; }
        required public string Name { get; set; }
    }
}

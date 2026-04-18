namespace CRAms.Data.DTOs.Write
{
    public class CreateProductDto
    {
        required public string Name { get; set; }
        public string? Description { get; set; }
    }
}

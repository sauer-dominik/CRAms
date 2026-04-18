using CRAms.Data.Enums;

namespace CRAms.Data.DTOs.Read
{
    public class ItemDto : EntityDto
    {
        required public string Description { get; set; }
        required public ItemType Type { get; set; }
    }
}

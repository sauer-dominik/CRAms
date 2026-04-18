using CRAms.Data.Enums;

namespace CRAms.Data.DTOs.Read
{
    public class UserDto : NamedEntityDto
    {
        required public Role Role { get; set; }
    }
}

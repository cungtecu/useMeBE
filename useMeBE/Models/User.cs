using useMeBE.Models.Enums;

namespace useMeBE.Models;

public class User
{
    public int Id { get; set; }
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
    public RoleEnum Role { get; set; }
    public StatusEnum Status { get; set; }
    public bool IsDelete { get; set; }
    public DateTime CreateAt { get; set; }
}

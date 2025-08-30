namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public required string DsiplayName { get; set; }
    public required string email { get; set; }
}

namespace DevSpaceWeb.Models;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public long ChatId { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime? LastMessage { get; set; }
    public List<Message>? Messages { get; set; }
}
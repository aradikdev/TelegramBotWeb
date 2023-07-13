namespace DevSpaceWeb.Models;

public class Message
{
    public int Id { get; set; }
    public string MessageText { get; set; }
    public DateTime MessageDate { get; set; }
    public long ChatId { get; set; }
    public bool IsOur { get; set; } = false;
    public bool IsSended { get; set; } = false;

    public int? UserId { get; set; }
    public virtual User User{ get; set; }
}

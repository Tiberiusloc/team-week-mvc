namespace ForageMvc.Models
{
  public class UserCard
  {
    public int UserCardId { get; set; }
    public int UserId { get; set; }
    public int CardId { get; set; }
    public virtual User User { get; set; }
    public virtual Card Card { get; set; }
  }
}
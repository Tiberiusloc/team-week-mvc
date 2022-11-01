using System.Collections.Generic;

namespace ForageMvc.Models
{
  public class Card
  {
    public Card()
    {
      this.JoinEntities = new HashSet<UserCard>();
    }
    public int CardId { get; set; }
    public string Title { get; set; }
    public string Type { get; set; }
    public string Difficulty { get; set; }
    public string ImageUrl { get; set; }
    public virtual ICollection<UserCard> JoinEntities { get; }

  }
}
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ForageMvc.Models
{
  public class User : IdentityUser
  {
    public User()
    {
      this.JoinEntities = new HashSet<UserCard>();
    }

    public virtual ICollection<UserCard> JoinEntities { get; }
    public int Score { get; set; }
  }
}
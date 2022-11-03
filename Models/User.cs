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
<<<<<<< HEAD
    
=======
    public virtual User Users { get; set; }
>>>>>>> 3ba572c48fc90cb93d30f0d0196243f877e93759
  }
}
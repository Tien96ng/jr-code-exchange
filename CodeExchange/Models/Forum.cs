using System.Collections.Generic;

namespace CodeExchange.Models
{
  public class Forum
  {
    public Forum()
    {
      this.JoinEntities =  new HashSet<AppUserForumPost>();
    }

    public int ForumId { get; set; }
    public string Name { get; set; }
    public virtual HashSet<AppUser> ForumFollowers { get; set; }
    public virtual ICollection<AppUserForumPost> JoinEntities { get; set; }
  }
}
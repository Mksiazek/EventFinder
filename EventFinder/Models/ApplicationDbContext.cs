using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace EventFinder.Models
{
  public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet <Event> Events { get; set; }
    public DbSet<Sport> Sports { get; set; }


    public ApplicationDbContext()
      : base("DefaultConnection", throwIfV1Schema: false)
    {
    }

    public static ApplicationDbContext Create()
    {
      return new ApplicationDbContext();
    }
  }
}
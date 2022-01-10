using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Chat.Models
{
  public class ChatContext : IdentityDbContext<ApplicationUser>
  {
    public DbSet<ApplicationUser> Users {get;set;}
    public ChatContext(DbContextOptions options) : base(options){}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}
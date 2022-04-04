using Microsoft.EntityFrameworkCore;
using webflix_server.Data.Models;

namespace webflix_server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base (options)
    {
        
    }

    public DbSet<User> Users { get; set; }

    public DbSet<SocialLink> SocialLinks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }
}
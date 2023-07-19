using Hometask.Models;
using Microsoft.EntityFrameworkCore;
namespace SeedData;

public class DataContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Hometask.Models.Task> Tasks { get; set; }
    public DbSet<Tag> Tags { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(DbConstans.DB_CONNECTIONSTRING);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "Test",
            });
        base.OnModelCreating(modelBuilder);
    }

}

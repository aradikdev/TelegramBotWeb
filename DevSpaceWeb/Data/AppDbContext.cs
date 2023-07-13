using DevSpaceWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace DevSpaceWeb.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Message> Messages { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Message>().HasData(
            new Message
            {
                Id = 1,
                MessageText = "Hi",
                MessageDate = DateTime.Now,
                UserId = 1,
                ChatId = 1,
                IsSended = true,
                IsOur = true
            },
            new Message
            {
                Id = 2,
                MessageText = "Hello",
                MessageDate = DateTime.Now.AddMinutes(1),
                UserId = 2,
                ChatId = 1,
                IsSended = true,
                IsOur = false
            },
            new Message
            {
                Id = 3,
                MessageText = "How are you?",
                MessageDate = DateTime.Now.AddMinutes(2),
                UserId = 1,
                ChatId = 1,
                IsSended = true,
                IsOur = true
            },
            new Message
            {
                Id = 4,
                MessageText = "I'm good, thanks!",
                MessageDate = DateTime.Now.AddMinutes(3),
                UserId = 2,
                ChatId = 1,
                IsSended = true,
                IsOur = false
            },
            new Message
            {
                Id = 5,
                MessageText = "What have you been up to?",
                MessageDate = DateTime.Now.AddMinutes(4),
                UserId = 1,
                ChatId = 1,
                IsSended = true,
                IsOur = true
            },
            new Message
            {
                Id = 6,
                MessageText = "Not much, just working on a project",
                MessageDate = DateTime.Now.AddMinutes(5),
                UserId = 2,
                ChatId = 1,
                IsSended = true,
                IsOur = false
            }
        );
        modelBuilder.Entity<User>().HasData(
            new User
            {
                Id = 1,
                Name = "Я",
                IsActive = true,
                ChatId = 1,
                LastMessage = null
            },
            new User
            {
                Id = 2,
                Name = "Alice",
                IsActive = true,
                ChatId = 1,
                LastMessage = null
            }
        );
    }
}
using GraphQLProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject.Data
{
    public class GraphQLDbContext : DbContext
    {
        public GraphQLDbContext(DbContextOptions<GraphQLDbContext> options) : base(options)
        {

        }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Note>().HasData(
                new Note() { Id = 1, Title = "Meeting Notes", Description = "Meeting with team to discuss project status.", CreatedAt = "2023-09-11 10:30 AM" },
                new Note() { Id = 2, Title = "Task List", Description = "List of tasks to complete this week.", CreatedAt = "2023-09-12 02:15 PM" },
                new Note() { Id = 3, Title = "Ideas", Description = "Brainstorming session for new project ideas.", CreatedAt = "2023-09-13 04:00 PM" },
                new Note() { Id = 4, Title = "Shopping List", Description = "Grocery shopping list for the weekend.", CreatedAt = "2023-09-14 08:00 AM" },
                new Note() { Id = 5, Title = "Project Outline", Description = "Outline for the upcoming project.", CreatedAt = "2023-09-15 09:30 AM" }
            );
        }

    }
}

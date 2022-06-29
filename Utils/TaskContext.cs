using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.Utils
{
    public class TaskContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(category =>
            {
                category.ToTable("Category");
                category.HasKey(p => p.IdCategory);
                category.Property(p => p.Name).IsRequired().HasMaxLength(150);
            });
        }
    }
}

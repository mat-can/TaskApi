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
                category.Property(p => p.Description);
                category.Property(p => p.Weight);
            });

            modelBuilder.Entity<Tasks>(task =>
            {
                task.ToTable("Tasks");
                task.HasKey(p => p.IdTask);
                task.HasOne(p=> p.Category).WithMany(p => p.Tasks).HasForeignKey(p => p.IdCategory);
                task.Property(p => p.Title).IsRequired().HasMaxLength(150);
                task.Property(p => p.Description).HasMaxLength(200);
                task.Property(p => p.TaskPriorities);
                task.Property(p => p.CreateTime);
                task.Ignore(p => p.Summary);
                task.Property(p => p.TaskState).IsRequired();
                task.Property(p => p.TaskTime);
            });
        }
    }
}

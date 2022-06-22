﻿using Microsoft.EntityFrameworkCore;
using TaskApi.Models;

namespace TaskApi.Utils
{
    public class TaskContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public TaskContext(DbContextOptions<TaskContext> options) : base(options)
        {
        }
    }
}

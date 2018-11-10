using Microsoft.EntityFrameworkCore;

namespace NETConfWebAPI.Data
{
    public class TasksContext : DbContext
    {
        public TasksContext()
        {

        }

        public virtual DbSet<Task> Tasks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tasks.db");
        }
    }
}
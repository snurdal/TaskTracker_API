using Microsoft.EntityFrameworkCore;
using TaskTracker_API.Model;

namespace TaskTracker_API.Data
{
    public class TaskTrackerContext : DbContext
    {
        public TaskTrackerContext(DbContextOptions<TaskTrackerContext> options) : base(options)
        {
        }

        public DbSet<TaskModel> Todos { get; set; }
    }
}

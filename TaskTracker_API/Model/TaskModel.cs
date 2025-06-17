using System.ComponentModel.DataAnnotations;

namespace TaskTracker_API.Model
{
    public class TaskModel
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public required string Content { get; set; }
        public bool IsComplete { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

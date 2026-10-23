using System.ComponentModel.DataAnnotations;

namespace Tasker.Models
{
    public class TaskItem
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Every taskitem needs a name...")]
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskManager.Models
{
    [Table("Task")]
    public class TaskModel
    {
        [Key]
        public int? TaskID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
    }
}

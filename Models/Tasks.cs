using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskApi.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        public Guid IdTask { get; set; }
        public Guid IdCategory { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priorities TaskPriorities { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual Category Category { get; set; }
        public string Summary { get; set; }
    }
    
    public enum Priorities
    {
        Low,
        Medium,
        High
    }
}

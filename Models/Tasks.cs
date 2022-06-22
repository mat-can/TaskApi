using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskApi.Models
{
    [Table("Tasks")]
    public class Tasks
    {
        [Key]
        [Required]
        public Guid IdTask { get; set; }
        [Required]
        [ForeignKey("CategoryId")]
        public Guid IdCategory { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        public string Description { get; set; }
        public Priorities TaskPriorities { get; set; }
        public DateTime CreateTime { get; set; }
        public virtual Category Category { get; set; }
        [NotMapped]
        public string Summary { get; set; }
    }
    
    public enum Priorities
    {
        Low,
        Medium,
        High
    }
}

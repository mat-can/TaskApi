using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskApi.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [Required]
        public Guid IdCategory { get; set; }
        [Required]
        [MaxLength(60)]
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}

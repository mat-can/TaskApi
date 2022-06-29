using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskApi.Models
{
    [Table("Category")]
    public class Category
    {
        public Guid IdCategory { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Tasks> Tasks { get; set; }
    }
}

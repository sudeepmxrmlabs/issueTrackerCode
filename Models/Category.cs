using System.ComponentModel.DataAnnotations;

namespace issueTracker.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        [StringLength(20)]
        public string Color { get; set; }
    }
}
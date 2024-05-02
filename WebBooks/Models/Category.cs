using System.ComponentModel.DataAnnotations;

namespace WebBooks.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public int DisplayOrder { get; set; }
    }
}

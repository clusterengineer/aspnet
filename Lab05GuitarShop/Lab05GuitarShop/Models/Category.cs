using System.ComponentModel.DataAnnotations;

namespace Lab05GuitarShop.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Please enter a category name.")]
        public string Name { get; set; } = string.Empty;
    }
}

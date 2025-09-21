using System.ComponentModel.DataAnnotations;

namespace EXAMEN_PARCIAL.Properties.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

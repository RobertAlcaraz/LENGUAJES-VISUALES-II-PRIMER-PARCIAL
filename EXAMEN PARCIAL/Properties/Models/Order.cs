using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EXAMEN_PARCIAL.Properties.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}

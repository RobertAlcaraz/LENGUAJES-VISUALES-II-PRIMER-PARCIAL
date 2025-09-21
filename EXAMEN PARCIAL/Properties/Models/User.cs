using System.ComponentModel.DataAnnotations;

namespace EXAMEN_PARCIAL.Properties.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string PasswordHash { get; set; }
        [Required]
        public string Email { get; set; }
        public string Role { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

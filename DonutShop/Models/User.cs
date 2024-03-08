using System.ComponentModel.DataAnnotations;

namespace DonutShop.Models
{
    public class User
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

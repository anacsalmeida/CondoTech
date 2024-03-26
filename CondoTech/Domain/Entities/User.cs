using System.ComponentModel.DataAnnotations;

namespace CondoTech.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public required string Password { get; set; }

        [Required]
        public required string Cpf { get; set; }

        public string AccessToken { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? LastLogin { get; set; }

        public bool IsActive { get; set; } = true;
    }
}

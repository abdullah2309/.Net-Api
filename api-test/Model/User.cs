using System.ComponentModel.DataAnnotations;

namespace api_test.Model
{
    public class User
    {
        [Key] // Primary key
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(255)]
        public string PasswordHash { get; set; } // store hashed password, not plain text


        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}

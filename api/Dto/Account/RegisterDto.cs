using System.ComponentModel.DataAnnotations;

namespace api.Dto.Account
{
    public class RegisterDto
    {
        [Required]
        public int StudentId { get; set; }
        
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string FullName { get; set; }

        [Required]
        public required string Password { get; set; }

        [Required]
        public required string Group { get; set; }
    }
}

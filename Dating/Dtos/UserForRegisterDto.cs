using System.ComponentModel.DataAnnotations;

namespace Dating.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(12, MinimumLength = 4, ErrorMessage = "You need to have a username between 4 and 12 characters")]
        public string Username { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "You must have a password between 4 and 8 characters")]
        public string Password { get; set; }
    }
}
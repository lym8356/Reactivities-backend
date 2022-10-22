using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        //password must contain 1 digit, 1 lower case 1 upper case
        //between length 4-8 
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must be complex.")]
        public string Password { get; set; }
        [Required]
        public string Username { get; set; }
    }
}
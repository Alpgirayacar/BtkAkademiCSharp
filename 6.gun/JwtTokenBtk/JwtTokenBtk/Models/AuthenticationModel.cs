using System.ComponentModel.DataAnnotations;

namespace JwtTokenBtk.Models
{
    public class AuthenticationModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

}

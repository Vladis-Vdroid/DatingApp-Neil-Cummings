using System.ComponentModel.DataAnnotations;

namespace APIDatingApp.DTO_s;

public class RegisterDto
{
    [Required]
    public required string Username { get; set; }
    [Required]
    public required string Password { get; set; }
}
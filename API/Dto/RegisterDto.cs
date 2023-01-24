using System.ComponentModel.DataAnnotations;

namespace API.Dto
{
  public class RegisterDto
  {
    [Required]
    public string Username { get; set; }


    [Required]
    public string KnownAs { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public DateOnly? DateOfBirth { get; set; } //optional to make required work!
    [Required]
    public string city { get; set; }
    [Required]
    public string Country { get; set; }

    [StringLength(8, MinimumLength = 4)]
    public string Password { get; set; }

  }
}
#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
namespace LoginAndRegistration.Models;
public class LogUser
{
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress]
    public string LEmail { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password must be atleast 8 characters")]
    public string LPassword { get; set; }
}
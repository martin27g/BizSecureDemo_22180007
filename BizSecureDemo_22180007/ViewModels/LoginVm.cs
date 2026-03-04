using System.ComponentModel.DataAnnotations;
namespace BizSecureDemo_22180007.ViewModels;

public class LoginVm
{
    [Required, EmailAddress]
    public string Email { get; set; } = "";
    [Required]
    public string Password { get; set; } = "";
}


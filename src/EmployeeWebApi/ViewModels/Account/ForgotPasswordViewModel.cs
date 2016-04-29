using System.ComponentModel.DataAnnotations;

namespace EmployeeWebApi.ViewModels.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Email của bạn")]
        [Required(ErrorMessage = "Vui lòng nhập email")]
        public string EmailAddress { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage ="Vui lòng nhập mật khẩu")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace SurveyApp.API.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Username cannot be empty")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

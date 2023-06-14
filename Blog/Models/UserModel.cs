using System.ComponentModel.DataAnnotations;

namespace Blog.Models
{
    public class UserModel
    {
        public int id { get; set; }
        public string login { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password is required")]
        public string confirm_password { get; set; }
         
        
    }
}

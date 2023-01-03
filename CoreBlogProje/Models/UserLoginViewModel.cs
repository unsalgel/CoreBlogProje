using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CoreBlogProje.Models
{
    public class UserLoginViewModel
    { 
        [Required(ErrorMessage = "Kullanıcı Adını Giriniz..")]
        public string UserName { get; set; }
        
        [Required(ErrorMessage = "Şifrenizi Giriniz..")]
        public string Password { get; set; }
    }
}

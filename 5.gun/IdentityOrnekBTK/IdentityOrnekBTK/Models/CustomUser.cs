using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace IdentityOrnekBTK.Models
{
    public class CustomUser : IdentityUser
    {
        [Display(Name = "Adı & Soyadı")]
        public string FullName { get; set; }

  

        [Display(Name = "Cinsiyet")]
        public string Gender { get; set; }

        [Display(Name = "Doğum Tarihi")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}

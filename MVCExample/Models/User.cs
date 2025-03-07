using System.ComponentModel.DataAnnotations;
using ValidationAttribute;

namespace MVCExample.Models
{
    public class User
    {
        [RequiredField]
        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Surname")]
        public String Surname { get; set; }
    }
}

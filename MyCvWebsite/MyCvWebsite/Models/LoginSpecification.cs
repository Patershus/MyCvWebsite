using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCvWebsite.Models
{
     public class LoginSpecification
    {
        [Required(ErrorMessage ="Please enter your username")]
        
         public string Username { get; set; }



        [Required (ErrorMessage ="Please enter your password")]
         public string Password { get; set; }
    }
}

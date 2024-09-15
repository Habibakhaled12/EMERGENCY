using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emergency.core.entity
{
    public class signup:IdentityUser
    {
    
       // public patient patient { get; set; }
     
        public Hospital hospital { get; set; }





    }
}

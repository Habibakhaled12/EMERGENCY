using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emergency.core.dto
{
    public class logindto
    {
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}

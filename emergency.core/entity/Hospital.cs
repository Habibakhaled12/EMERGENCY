using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace emergency.core.entity
{
    public class Hospital
    {

        public int id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }       
        public double Rate { get; set; }
        public int NumOfBeds { get; set; }
        public int NumOfAvailableBeds { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
        public string phone { get; set; }
        public string signupId { get; set; }
        [ForeignKey("signupId")]
        public signup signup { get; set; }


    }
}



using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emergency.core.dto
{
    public class HospitalDto
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }

        public double Rate { get; set; }

        public int NumOfBeds { get; set; }

        public int NumOfAvailableBeds { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string SignupId { get; set; }
    }
}

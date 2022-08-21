using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace INF272_HW04.Models
{
    public class VolunteerVM
    {
        [Display(Name = "Volunteer ID")]
        public int ID { get; set; }



        [Display(Name = "Preferred Name")] //Add as decorator
        public string Name { get; set; }



        [Display(Name = "Surname")] //Add as decorator
        public string Surname { get; set; }


        public Nullable<int> Age { get; set; } = 0;


        [Display(Name = "Province")] //Add as decorator
        public string Province { get; set; }

    }
}
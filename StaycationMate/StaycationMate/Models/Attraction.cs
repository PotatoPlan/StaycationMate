using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StaycationMate.Models
{
    public class Attraction
    {
        public int Id { get; set; }

        [Required]
        [StringLength(225)]
        [Display(Name = "Location Name")]
        public string Location_Name { get; set; }

        [Required]
        [StringLength(225)]
        [Display(Name = "Street Address")]
        public string Street_Address { get; set; }

        [Required]
        [StringLength(225)]
        public string City { get; set; }

        [Required]
        [StringLength(225)]
        public string State { get; set; }

        [Required]
        [StringLength(225)]
        [Display(Name = "Postal Code")]
        public string Postal_Code { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Thumbnail { get; set; }

        public string Alternative_Text { get; set; }

        [Range(0, 10)]
        [Required]
        public int Rating { get; set; }
    }
}
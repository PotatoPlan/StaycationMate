using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StaycationMate.Models
{
    public class MyTrip
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Destination { get; set; }

        public DateTime TripDate { get; set; }

        [Range(0, 10)]
        [Display(Name = "Rating")]
        public int? User_Rating { get; set; }
    }
}
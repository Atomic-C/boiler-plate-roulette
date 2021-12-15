using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerPlateRouletteSolution.Models
{
    public class NumberStats
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Range(0,36, ErrorMessage = "Whole Numbers between 0 and 36.")]
        public int Number { get; set; } // We will have a total of 37 numbers here.
        public int Quantity { get; set; } // We count each number, Color, parity, hot\cold to make statistic in percentage
        public string Color { get; set; } // Can be Red, Black or Green.
        //public string EvenOdd { get; set; } // Can be Even or Odd
        //public string HotCold { get; set; } // To make the top 3 Hot, and top bottom Cold numbers
        public int Percentage { get; set; } // To hold statistics

        // We know that colors, odds and even are constant values as well as numbers range between 0 - 36
    }
}

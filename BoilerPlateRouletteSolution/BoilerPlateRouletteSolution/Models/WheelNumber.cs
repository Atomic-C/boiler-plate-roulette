using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerPlateRouletteSolution.Models
{
    public class WheelNumber
    {
        public int Number { get; }
        public WheelNumberColorEnum Color { get; }

        public WheelNumber(int number, WheelNumberColorEnum color)
        {
                Number = number;
                Color = color;
        }
    }
}
